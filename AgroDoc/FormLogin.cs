using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgroDoc
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnGoToRegister_Click_1(object sender, EventArgs e)
        {
            FormRegister regForm = new FormRegister();
            this.Hide();
            regForm.ShowDialog();
            this.Show(); // Re-shows login form once user finishes or cancels registration
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validation: Check for empty fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    // Parameterized query prevents SQL injection attacks
                    string query = @"SELECT FarmerId, FullName, Username, Location 
                                     FROM Farmers 
                                     WHERE Username = @username AND Password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Store user data in global Session
                                Session.FarmerId = Convert.ToInt32(reader["FarmerId"]);
                                Session.FullName = reader["FullName"].ToString();
                                Session.Username = reader["Username"].ToString();
                                Session.Location = reader["Location"].ToString();

                                MessageBox.Show($"Welcome back, {Session.FullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Hide login form and show Main Dashboard
                                this.Hide();
                                MainForm mainForm = new MainForm();
                                mainForm.ShowDialog();

                                // Close application completely when MainForm closes
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPassword.Clear();
                                txtPassword.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}