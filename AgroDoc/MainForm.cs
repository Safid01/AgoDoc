using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroDoc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Session.IsLoggedIn)
            {
                lblWelcome.Text = $"Welcome, {Session.FullName} | Location: {Session.Location}";
            }
            else
            {
                lblWelcome.Text = "Welcome, Guest Farmer";
            }
        }

        private void btnSoilIndex_Click(object sender, EventArgs e)
        {
            FormSoilIndex form = new FormSoilIndex();
            form.ShowDialog();
        }

        private void btnCropSuggestion_Click(object sender, EventArgs e)
        {
            FormCropSuggestion form = new FormCropSuggestion();
            form.ShowDialog();
        }

        private void btnFertilizer_Click(object sender, EventArgs e)
        {
            FormFertilizer form = new FormFertilizer();
            form.ShowDialog();
        }

        private void btnStorageTracker_Click(object sender, EventArgs e)
        {
            FormStorageTracker form = new FormStorageTracker();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Session.Clear(); 
                this.Hide();

                FormLogin login = new FormLogin();
                login.ShowDialog();

                this.Close(); 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want to close AgroDoc?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
