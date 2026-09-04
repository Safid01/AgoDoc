using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AgroDoc
{
    public partial class FormStorageTracker : Form
    {
        public FormStorageTracker()
        {
            InitializeComponent();
        }

        private void FormStorageTracker_Load(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn)
            {
                MessageBox.Show("Please log in first.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            rbRestock.Checked = true;
            rbHarvested.Checked = true; 

            PopulateDropdowns();
            LoadFertilizerStock();
            LoadHarvestStock();
        }

        private void PopulateDropdowns()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    // Load fertilizers
                    using (SqlCommand cmd = new SqlCommand("SELECT FertilizerName FROM Fertilizers ORDER BY FertilizerName", conn))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            cmbFertilizerName.Items.Clear();
                            while (rdr.Read())
                            {
                                cmbFertilizerName.Items.Add(rdr["FertilizerName"].ToString());
                            }
                            if (cmbFertilizerName.Items.Count > 0) cmbFertilizerName.SelectedIndex = 0;
                        }
                    }

                    // Load crops
                    using (SqlCommand cmd = new SqlCommand("SELECT CropName FROM Crops ORDER BY CropName", conn))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            cmbHarvestCrop.Items.Clear();
                            while (rdr.Read())
                            {
                                cmbHarvestCrop.Items.Add(rdr["CropName"].ToString());
                            }
                            if (cmbHarvestCrop.Items.Count > 0) cmbHarvestCrop.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dropdown data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load Fertilizer Inventory for Logged-In Farmer
        public void LoadFertilizerStock()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string query = @"SELECT StockId, FertilizerName AS [Fertilizer], 
                                            QuantityKg AS [Stock (KG)], 
                                            CONVERT(VARCHAR(16), LastUpdated, 120) AS [Last Updated] 
                                     FROM FertilizerStock 
                                     WHERE FarmerId = @FarmerId 
                                     ORDER BY FertilizerName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FarmerId", Session.FarmerId);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvFertilizerStock.DataSource = dt;

                        if (dgvFertilizerStock.Columns["StockId"] != null)
                            dgvFertilizerStock.Columns["StockId"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading fertilizer stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load Harvest Inventory for Logged-In Farmer
        public void LoadHarvestStock()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string query = @"SELECT HarvestId, CropName AS [Crop], 
                                            QuantityKg AS [Current Stock (KG)], 
                                            CONVERT(VARCHAR(10), HarvestDate, 120) AS [Last Action Date], 
                                            StorageLocation AS [Storage Silo/Place], 
                                            Notes 
                                     FROM HarvestStock 
                                     WHERE FarmerId = @FarmerId 
                                     ORDER BY CropName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FarmerId", Session.FarmerId);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvHarvestStock.DataSource = dt;

                        if (dgvHarvestStock.Columns["HarvestId"] != null)
                            dgvHarvestStock.Columns["HarvestId"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading harvest stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Save/Update Fertilizer Stock (+ or -)
        private void btnSaveFertilizer_Click(object sender, EventArgs e)
        {
            if (cmbFertilizerName.SelectedItem == null)
            {
                MessageBox.Show("Please select a fertilizer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtFertQuantity.Text.Trim(), out decimal enteredQty) || enteredQty <= 0)
            {
                MessageBox.Show("Please enter a valid positive quantity in KG.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fertName = cmbFertilizerName.SelectedItem.ToString();
            bool isRestock = rbRestock.Checked;

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    // Check existing stock
                    string selectQuery = "SELECT StockId, QuantityKg FROM FertilizerStock WHERE FarmerId = @FarmerId AND FertilizerName = @FertName";
                    decimal currentQty = 0;
                    int stockId = 0;
                    bool exists = false;

                    using (SqlCommand cmdSelect = new SqlCommand(selectQuery, conn))
                    {
                        cmdSelect.Parameters.AddWithValue("@FarmerId", Session.FarmerId);
                        cmdSelect.Parameters.AddWithValue("@FertName", fertName);

                        using (SqlDataReader rdr = cmdSelect.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                exists = true;
                                stockId = Convert.ToInt32(rdr["StockId"]);
                                currentQty = Convert.ToDecimal(rdr["QuantityKg"]);
                            }
                        }
                    }

                    if (isRestock)
                    {
                        if (exists)
                        {
                            string updateSql = "UPDATE FertilizerStock SET QuantityKg = QuantityKg + @Qty, LastUpdated = GETDATE() WHERE StockId = @StockId";
                            using (SqlCommand cmdUpd = new SqlCommand(updateSql, conn))
                            {
                                cmdUpd.Parameters.AddWithValue("@Qty", enteredQty);
                                cmdUpd.Parameters.AddWithValue("@StockId", stockId);
                                cmdUpd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertSql = "INSERT INTO FertilizerStock (FarmerId, FertilizerName, QuantityKg) VALUES (@FarmerId, @FertName, @Qty)";
                            using (SqlCommand cmdIns = new SqlCommand(insertSql, conn))
                            {
                                cmdIns.Parameters.AddWithValue("@FarmerId", Session.FarmerId);
                                cmdIns.Parameters.AddWithValue("@FertName", fertName);
                                cmdIns.Parameters.AddWithValue("@Qty", enteredQty);
                                cmdIns.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show($"Added {enteredQty} KG of {fertName} to stock.", "Stock Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Field application (Deduct)
                    {
                        if (!exists || currentQty < enteredQty)
                        {
                            MessageBox.Show($"Insufficient stock! You currently have {currentQty} KG of {fertName}.", "Cannot Deduct", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string deductSql = "UPDATE FertilizerStock SET QuantityKg = QuantityKg - @Qty, LastUpdated = GETDATE() WHERE StockId = @StockId";
                        using (SqlCommand cmdDed = new SqlCommand(deductSql, conn))
                        {
                            cmdDed.Parameters.AddWithValue("@Qty", enteredQty);
                            cmdDed.Parameters.AddWithValue("@StockId", stockId);
                            cmdDed.ExecuteNonQuery();
                        }
                        MessageBox.Show($"Deducted {enteredQty} KG of {fertName}. Remaining: {currentQty - enteredQty} KG.", "Stock Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    txtFertQuantity.Text = "0";
                    LoadFertilizerStock();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Record/Update Harvest Yield (+ Harvested or - Sold)
        private void btnSaveHarvest_Click_1(object sender, EventArgs e)
        {
            if (cmbHarvestCrop.SelectedItem == null)
            {
                MessageBox.Show("Please select a crop.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtHarvestQuantity.Text.Trim(), out decimal enteredQty) || enteredQty <= 0)
            {
                MessageBox.Show("Please enter a valid positive quantity in KG.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cropName = cmbHarvestCrop.SelectedItem.ToString();
            string location = string.IsNullOrWhiteSpace(txtStorageLocation.Text) ? "Main Granary" : txtStorageLocation.Text.Trim();
            string notes = txtHarvestNotes.Text.Trim();
            DateTime actionDate = dtpHarvestDate.Value.Date;
            bool isHarvested = rbHarvested.Checked;

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    // Check if crop already exists in harvest stock
                    string selectQuery = "SELECT HarvestId, QuantityKg FROM HarvestStock WHERE FarmerId = @FarmerId AND CropName = @CropName";
                    decimal currentQty = 0;
                    int harvestId = 0;
                    bool exists = false;

                    using (SqlCommand cmdSelect = new SqlCommand(selectQuery, conn))
                    {
                        cmdSelect.Parameters.AddWithValue("@FarmerId", Session.FarmerId);
                        cmdSelect.Parameters.AddWithValue("@CropName", cropName);

                        using (SqlDataReader rdr = cmdSelect.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                exists = true;
                                harvestId = Convert.ToInt32(rdr["HarvestId"]);
                                currentQty = Convert.ToDecimal(rdr["QuantityKg"]);
                            }
                        }
                    }

                    if (isHarvested) // Harvested (+)
                    {
                        if (exists)
                        {
                            string updateSql = @"UPDATE HarvestStock 
                                                 SET QuantityKg = QuantityKg + @Qty, 
                                                     HarvestDate = @Date, 
                                                     StorageLocation = @Loc, 
                                                     Notes = @Notes 
                                                 WHERE HarvestId = @HarvestId";
                            using (SqlCommand cmdUpd = new SqlCommand(updateSql, conn))
                            {
                                cmdUpd.Parameters.AddWithValue("@Qty", enteredQty);
                                cmdUpd.Parameters.AddWithValue("@Date", actionDate);
                                cmdUpd.Parameters.AddWithValue("@Loc", location);
                                cmdUpd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes);
                                cmdUpd.Parameters.AddWithValue("@HarvestId", harvestId);
                                cmdUpd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertSql = @"INSERT INTO HarvestStock (FarmerId, CropName, QuantityKg, HarvestDate, StorageLocation, Notes) 
                                                 VALUES (@FarmerId, @Crop, @Qty, @Date, @Loc, @Notes)";
                            using (SqlCommand cmdIns = new SqlCommand(insertSql, conn))
                            {
                                cmdIns.Parameters.AddWithValue("@FarmerId", Session.FarmerId);
                                cmdIns.Parameters.AddWithValue("@Crop", cropName);
                                cmdIns.Parameters.AddWithValue("@Qty", enteredQty);
                                cmdIns.Parameters.AddWithValue("@Date", actionDate);
                                cmdIns.Parameters.AddWithValue("@Loc", location);
                                cmdIns.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes);
                                cmdIns.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show($"Added {enteredQty} KG of {cropName} to stock.", "Stock Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Sold (-)
                    {
                        if (!exists || currentQty < enteredQty)
                        {
                            MessageBox.Show($"Insufficient stock! You currently have {currentQty} KG of {cropName} available to sell.", "Cannot Deduct", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string deductSql = @"UPDATE HarvestStock 
                                             SET QuantityKg = QuantityKg - @Qty, 
                                                 HarvestDate = @Date, 
                                                 Notes = @Notes 
                                             WHERE HarvestId = @HarvestId";
                        using (SqlCommand cmdDed = new SqlCommand(deductSql, conn))
                        {
                            cmdDed.Parameters.AddWithValue("@Qty", enteredQty);
                            cmdDed.Parameters.AddWithValue("@Date", actionDate);
                            cmdDed.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(notes) ? "Sold produce" : notes);
                            cmdDed.Parameters.AddWithValue("@HarvestId", harvestId);
                            cmdDed.ExecuteNonQuery();
                        }
                        MessageBox.Show($"Recorded sale of {enteredQty} KG of {cropName}. Remaining stock: {currentQty - enteredQty} KG.", "Stock Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    txtHarvestQuantity.Text = "0";
                    txtHarvestNotes.Clear();
                    LoadHarvestStock();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving harvest transaction: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Open Dedicated Delete Form
        private void btnGoToDelete_Click(object sender, EventArgs e)
        {
            FormDeleteStorage deleteForm = new FormDeleteStorage();
            deleteForm.ShowDialog();

            LoadFertilizerStock();
            LoadHarvestStock();
        }
    }
}