using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
// Explicitly alias WinForms Charting to avoid collision with System.Web
using WinChart = System.Windows.Forms.DataVisualization.Charting;

namespace AgroDoc
{
    public partial class FormSoilIndex : Form
    {
        public FormSoilIndex()
        {
            InitializeComponent();
        }

        private void FormSoilIndex_Load(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn)
            {
                MessageBox.Show("Please log in first.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            if (cmbSoilType.Items.Count > 0)
                cmbSoilType.SelectedIndex = 0;

            SetupChartSeries();
            LoadSoilHistory();
            LoadLatestSoilRecord();
        }

        private void SetupChartSeries()
        {
            chartSoilNPK.Series.Clear();

            // 1. Current Farmer Values Series
            WinChart.Series sCurrent = new WinChart.Series("Current Level")
            {
                ChartType = WinChart.SeriesChartType.Column,
                Color = Color.FromArgb(45, 106, 79),
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold)
            };

            // 2. National Optimal Benchmark Series
            WinChart.Series sOptimal = new WinChart.Series("Optimal Benchmark")
            {
                ChartType = WinChart.SeriesChartType.Column,
                Color = Color.FromArgb(201, 24, 74),
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold)
            };

            chartSoilNPK.Series.Add(sCurrent);
            chartSoilNPK.Series.Add(sOptimal);

            RenderChart(0, 0, 0, 0);
        }

        private void RenderChart(int n, int p, int k, decimal ph)
        {
            if (chartSoilNPK.Series.Count < 2) return;

            chartSoilNPK.Series["Current Level"].Points.Clear();
            chartSoilNPK.Series["Optimal Benchmark"].Points.Clear();

            // Current user values
            chartSoilNPK.Series["Current Level"].Points.AddXY("N (ppm)", n);
            chartSoilNPK.Series["Current Level"].Points.AddXY("P (ppm)", p);
            chartSoilNPK.Series["Current Level"].Points.AddXY("K (ppm)", k);
            chartSoilNPK.Series["Current Level"].Points.AddXY("pH (x10)", (double)(ph * 10));

            // Standard BARI/BRRI benchmarks
            chartSoilNPK.Series["Optimal Benchmark"].Points.AddXY("N (ppm)", 120);
            chartSoilNPK.Series["Optimal Benchmark"].Points.AddXY("P (ppm)", 30);
            chartSoilNPK.Series["Optimal Benchmark"].Points.AddXY("K (ppm)", 150);
            chartSoilNPK.Series["Optimal Benchmark"].Points.AddXY("pH (x10)", 65);

            chartSoilNPK.Invalidate();
        }

        private void btnSaveEvaluate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbSoilType.Text))
            {
                MessageBox.Show("Please select a soil type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtN.Text.Trim(), out int n) || n < 0 ||
                !int.TryParse(txtP.Text.Trim(), out int p) || p < 0 ||
                !int.TryParse(txtK.Text.Trim(), out int k) || k < 0)
            {
                MessageBox.Show("Please enter valid positive integers for N, P, and K.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPh.Text.Trim(), out decimal ph) || ph < 0 || ph > 14)
            {
                MessageBox.Show("Please enter a valid pH between 0.0 and 14.0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soilType = cmbSoilType.Text.Trim();
            string rating;
            string comments = GenerateDiagnostics(n, p, k, ph, out rating);

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string query = @"INSERT INTO SoilRecords (FarmerId, SoilType, Nitrogen, Phosphorus, Potassium, PhLevel, HealthRating, AnalysisComments) 
                                     VALUES (@FarmerId, @SoilType, @N, @P, @K, @Ph, @Rating, @Comments)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FarmerId", Session.FarmerId);
                        cmd.Parameters.AddWithValue("@SoilType", soilType);
                        cmd.Parameters.AddWithValue("@N", n);
                        cmd.Parameters.AddWithValue("@P", p);
                        cmd.Parameters.AddWithValue("@K", k);
                        cmd.Parameters.AddWithValue("@Ph", ph);
                        cmd.Parameters.AddWithValue("@Rating", rating);
                        cmd.Parameters.AddWithValue("@Comments", comments);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                lblHealthBadge.Text = rating;
                lblHealthBadge.ForeColor = rating.Contains("Optimal") ? Color.FromArgb(45, 106, 79) : Color.FromArgb(201, 24, 74);
                txtDoctorComments.Text = comments;
                RenderChart(n, p, k, ph);
                LoadSoilHistory();

                MessageBox.Show("Soil sample evaluated and saved successfully!", "Diagnosis Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateDiagnostics(int n, int p, int k, decimal ph, out string rating)
        {
            string comments = "";
            int deficitCount = 0;

            if (n < 80) { comments += "• Nitrogen is severely deficient. Apply Urea or organic compost.\r\n"; deficitCount++; }
            else if (n > 180) { comments += "• High Nitrogen detected. Avoid excess nitrogenous fertilizers.\r\n"; }

            if (p < 20) { comments += "• Phosphorus is low. Apply Triple Superphosphate (TSP) or DAP.\r\n"; deficitCount++; }

            if (k < 100) { comments += "• Potassium is deficient. Apply Muriate of Potash (MOP).\r\n"; deficitCount++; }

            if (ph < 5.5m) { comments += "• Strongly Acidic Soil. Apply Agricultural Lime (Dolomite).\r\n"; deficitCount++; }
            else if (ph > 7.5m) { comments += "• Alkaline Soil condition. Consider Gypsum or organic mulching.\r\n"; deficitCount++; }

            if (deficitCount == 0)
            {
                rating = "Optimal & Fertile";
                comments = "• Soil nutrients are well-balanced. Suitable for high-yield seasonal crops.\r\n" + comments;
            }
            else if (deficitCount <= 2)
            {
                rating = "Moderate / Deficient";
            }
            else
            {
                rating = "Critical / Poor Health";
            }

            return comments;
        }

        private void LoadSoilHistory()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string query = @"SELECT RecordId AS [ID], 
                                            CONVERT(VARCHAR(10), TestedAt, 120) AS [Test Date],
                                            SoilType AS [Soil Type], 
                                            Nitrogen AS [N], 
                                            Phosphorus AS [P], 
                                            Potassium AS [K], 
                                            PhLevel AS [pH], 
                                            HealthRating AS [Rating] 
                                     FROM SoilRecords 
                                     WHERE FarmerId = @FarmerId 
                                     ORDER BY TestedAt DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FarmerId", Session.FarmerId);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSoilHistory.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading soil history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLatestSoilRecord()
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string query = @"SELECT TOP 1 SoilType, Nitrogen, Phosphorus, Potassium, PhLevel, HealthRating, AnalysisComments 
                                     FROM SoilRecords 
                                     WHERE FarmerId = @FarmerId 
                                     ORDER BY TestedAt DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FarmerId", Session.FarmerId);
                        conn.Open();
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                cmbSoilType.Text = rdr["SoilType"].ToString();
                                int n = Convert.ToInt32(rdr["Nitrogen"]);
                                int p = Convert.ToInt32(rdr["Phosphorus"]);
                                int k = Convert.ToInt32(rdr["Potassium"]);
                                decimal ph = Convert.ToDecimal(rdr["PhLevel"]);

                                txtN.Text = n.ToString();
                                txtP.Text = p.ToString();
                                txtK.Text = k.ToString();
                                txtPh.Text = ph.ToString();

                                string rating = rdr["HealthRating"].ToString();
                                lblHealthBadge.Text = rating;
                                lblHealthBadge.ForeColor = rating.Contains("Optimal") ? Color.FromArgb(45, 106, 79) : Color.FromArgb(201, 24, 74);
                                txtDoctorComments.Text = rdr["AnalysisComments"].ToString();

                                RenderChart(n, p, k, ph);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading latest record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadLatest_Click(object sender, EventArgs e)
        {
            LoadLatestSoilRecord();
        }

        private void btnGoToFertilizer_Click(object sender, EventArgs e)
        {
            FormFertilizer fertForm = new FormFertilizer();
            fertForm.ShowDialog();
        }
    }
}