using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgroDoc
{
    public partial class FormDeleteStorage : Form
    {
        public FormDeleteStorage()
        {
            InitializeComponent();
        }

        private void FormDeleteStorage_Load(object sender, EventArgs e)
        {
            if (cmbCategory.Items.Count == 0)
            {
                cmbCategory.Items.Add("Fertilizer Inventory");
                cmbCategory.Items.Add("Harvested Produce Log");
            }
            cmbCategory.SelectedIndex = 0;
            LoadSelectedCategoryData();
        }

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadSelectedCategoryData();
        }

        private void LoadSelectedCategoryData()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string query = "";
                    if (cmbCategory.SelectedIndex == 0) // Fertilizer
                    {
                        query = @"SELECT StockId AS [ID], FertilizerName AS [Fertilizer Name], 
                                         QuantityKg AS [Current Stock (KG)], LastUpdated AS [Updated At] 
                                  FROM FertilizerStock WHERE FarmerId = @FarmerId";
                    }
                    else // Harvest
                    {
                        query = @"SELECT HarvestId AS [ID], CropName AS [Crop Name], 
                                         QuantityKg AS [Yield (KG)], HarvestDate AS [Harvest Date], StorageLocation 
                                  FROM HarvestStock WHERE FarmerId = @FarmerId";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FarmerId", Session.FarmerId);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvDeleteView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDeleteView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvDeleteView.SelectedRows[0].Cells["ID"].Value);
            string categoryName = cmbCategory.SelectedItem.ToString();

            DialogResult confirm = MessageBox.Show($"Are you sure you want to permanently delete this {categoryName} entry?",
                                                 "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    string deleteQuery = cmbCategory.SelectedIndex == 0
                        ? "DELETE FROM FertilizerStock WHERE StockId = @Id AND FarmerId = @FarmerId"
                        : "DELETE FROM HarvestStock WHERE HarvestId = @Id AND FarmerId = @FarmerId";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@FarmerId", Session.FarmerId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSelectedCategoryData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}