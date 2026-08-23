using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AgroDoc
{
    public partial class FormFertilizer : Form
    {
        public FormFertilizer()
        {
            InitializeComponent();
        }

        // 1. Form Load: Load crops into the ComboBox
        private void FormFertilizer_Load(object sender, EventArgs e)
        {
            LoadCropsDropdown();
        }

        private void LoadCropsDropdown()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT CropId, CropName FROM Crops ORDER BY CropName ASC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            cmbTargetCrop.DisplayMember = "CropName";
                            cmbTargetCrop.ValueMember = "CropId";
                            cmbTargetCrop.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading crops list: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Load the farmer's most recent soil test from SoilRecords
        private void btnLoadLatest_Click(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn)
            {
                MessageBox.Show("No active farmer session found. Please log in first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT TOP 1 Nitrogen, Phosphorus, Potassium, PhLevel, TestedAt 
                                     FROM SoilRecords 
                                     WHERE FarmerId = @FarmerId 
                                     ORDER BY TestedAt DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FarmerId", Session.FarmerId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtN.Text = reader["Nitrogen"].ToString();
                                txtP.Text = reader["Phosphorus"].ToString();
                                txtK.Text = reader["Potassium"].ToString();
                                txtPh.Text = Convert.ToDecimal(reader["PhLevel"]).ToString("0.0");

                                DateTime testDate = Convert.ToDateTime(reader["TestedAt"]);
                                MessageBox.Show($"Loaded soil record from: {testDate:yyyy-MM-dd HH:mm}", "Record Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No previous soil records found for your account. Please enter the values manually.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching recent soil record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Analyze soil deficits against the target crop and recommend fertilizers
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Input Validation
            if (!int.TryParse(txtN.Text.Trim(), out int currentN) || currentN < 0 ||
                !int.TryParse(txtP.Text.Trim(), out int currentP) || currentP < 0 ||
                !int.TryParse(txtK.Text.Trim(), out int currentK) || currentK < 0 ||
                !decimal.TryParse(txtPh.Text.Trim(), out decimal currentPh) || currentPh < 0 || currentPh > 14)
            {
                MessageBox.Show("Please enter valid positive numbers for N, P, K, and a pH between 0 and 14.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTargetCrop.SelectedValue == null)
            {
                MessageBox.Show("Please select a target crop.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cropId = Convert.ToInt32(cmbTargetCrop.SelectedValue);

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    // Step A: Retrieve target crop nutrient requirements
                    int minN = 0, maxN = 0, minP = 0, maxP = 0, minK = 0, maxK = 0;
                    decimal minPh = 0, maxPh = 0;
                    string cropName = "";

                    string cropQuery = "SELECT CropName, MinN, MaxN, MinP, MaxP, MinK, MaxK, MinPh, MaxPh FROM Crops WHERE CropId = @CropId";
                    using (SqlCommand cmdCrop = new SqlCommand(cropQuery, conn))
                    {
                        cmdCrop.Parameters.AddWithValue("@CropId", cropId);
                        using (SqlDataReader reader = cmdCrop.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cropName = reader["CropName"].ToString();
                                minN = Convert.ToInt32(reader["MinN"]);
                                maxN = Convert.ToInt32(reader["MaxN"]);
                                minP = Convert.ToInt32(reader["MinP"]);
                                maxP = Convert.ToInt32(reader["MaxP"]);
                                minK = Convert.ToInt32(reader["MinK"]);
                                maxK = Convert.ToInt32(reader["MaxK"]);
                                minPh = Convert.ToDecimal(reader["MinPh"]);
                                maxPh = Convert.ToDecimal(reader["MaxPh"]);
                            }
                        }
                    }

                    // Step B: Calculate Deficits
                    string summary = $"Diagnostic for '{cropName}':\r\n";
                    bool needsN = false, needsP = false, needsK = false, needsLime = false, needsGypsum = false;

                    // Nitrogen check
                    if (currentN < minN)
                    {
                        summary += $"• Nitrogen Deficit: Short by {minN - currentN} units (Soil: {currentN}, Required: {minN}-{maxN})\r\n";
                        needsN = true;
                    }
                    else
                    {
                        summary += $"• Nitrogen: Optimal ({currentN} units)\r\n";
                    }

                    // Phosphorus check
                    if (currentP < minP)
                    {
                        summary += $"• Phosphorus Deficit: Short by {minP - currentP} units (Soil: {currentP}, Required: {minP}-{maxP})\r\n";
                        needsP = true;
                    }
                    else
                    {
                        summary += $"• Phosphorus: Optimal ({currentP} units)\r\n";
                    }

                    // Potassium check
                    if (currentK < minK)
                    {
                        summary += $"• Potassium Deficit: Short by {minK - currentK} units (Soil: {currentK}, Required: {minK}-{maxK})\r\n";
                        needsK = true;
                    }
                    else
                    {
                        summary += $"• Potassium: Optimal ({currentK} units)\r\n";
                    }

                    // pH Balance check
                    if (currentPh < minPh)
                    {
                        summary += $"• Soil is Too Acidic (pH {currentPh:0.0} < Ideal {minPh:0.0})\r\n";
                        needsLime = true;
                    }
                    else if (currentPh > maxPh)
                    {
                        summary += $"• Soil is Too Alkaline (pH {currentPh:0.0} > Ideal {maxPh:0.0})\r\n";
                        needsGypsum = true;
                    }
                    else
                    {
                        summary += $"• Soil pH is Balanced ({currentPh:0.0})\r\n";
                    }

                    txtDeficitSummary.Text = summary;

                    // Step C: Build SQL Filter for Fertilizers Table
                    string fertQuery = @"SELECT FertilizerName, TargetNutrient, ApplicationRate, Description 
                                         FROM Fertilizers 
                                         WHERE 1=0"; // default false condition

                    if (needsN) fertQuery += " OR TargetNutrient = 'Nitrogen'";
                    if (needsP) fertQuery += " OR TargetNutrient = 'Phosphorus'";
                    if (needsK) fertQuery += " OR TargetNutrient = 'Potassium'";
                    if (needsLime) fertQuery += " OR TargetNutrient = 'Low_pH'";
                    if (needsGypsum) fertQuery += " OR TargetNutrient = 'High_pH'";

                    if (!needsN && !needsP && !needsK && !needsLime && !needsGypsum)
                    {
                        // Soil is already ideal
                        dgvFertilizers.DataSource = null;
                        txtDeficitSummary.Text += "\r\n🎉 Your soil already has optimal nutrients for cultivating " + cropName + "!";
                        return;
                    }

                    using (SqlCommand cmdFert = new SqlCommand(fertQuery, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmdFert))
                        {
                            DataTable dtFert = new DataTable();
                            adapter.Fill(dtFert);
                            dgvFertilizers.DataSource = dtFert;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating suggestions: " + ex.Message, "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. Clear Inputs
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtP.Clear();
            txtK.Clear();
            txtPh.Clear();
            txtDeficitSummary.Clear();
            dgvFertilizers.DataSource = null;
        }
    }
}