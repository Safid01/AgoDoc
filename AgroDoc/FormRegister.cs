using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgroDoc
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            if (cmbLocation.Items.Count == 0)
            {
                cmbLocation.Items.AddRange(new string[] {
                    "Dhaka", "Bogura", "Rajshahi", "Rangpur",
                    "Cumilla", "Mymensingh", "Khulna", "Sylhet", "Dinajpur", "Pabna"
                });
                cmbLocation.SelectedIndex = 0;
            }
        }

        // 1. Account Creation Logic
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string location = cmbLocation.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // Field Validations
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(location) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields are required. Please complete the form.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    // Check if username is already taken
                    string checkUserQuery = "SELECT COUNT(*) FROM Farmers WHERE Username = @username";
                    using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("This username is already taken. Please choose another one.", "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUsername.Focus();
                            return;
                        }
                    }

                    // Insert the new Farmer record
                    string insertQuery = @"INSERT INTO Farmers (FullName, Username, Password, Phone, Location) 
                                           VALUES (@fullName, @username, @password, @phone, @location)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@fullName", fullName);
                        insertCmd.Parameters.AddWithValue("@username", username);
                        insertCmd.Parameters.AddWithValue("@password", password);
                        insertCmd.Parameters.AddWithValue("@phone", phone);
                        insertCmd.Parameters.AddWithValue("@location", location);

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account successfully created! You can now sign in.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}