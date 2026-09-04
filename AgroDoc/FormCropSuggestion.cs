using AgroDoc.Models;
using AgroDoc.Data;
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
    public partial class FormCropSuggestion : Form
    {
        private CropRepository cropRepository;

        public FormCropSuggestion()
        {
            InitializeComponent();
            cropRepository = new CropRepository();

            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "dd/MM/yyyy";

            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = "dd/MM/yyyy";

            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddDays(100);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void flpResults_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSuggestCrop_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text.Trim();

            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            // Check location
            if (string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show(
                    "Please enter a location.",
                    "Input Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLocation.Focus();

                return;
            }

            // Check date
            if (endDate <= startDate)
            {
                MessageBox.Show(
                    "End date must be after the start date.",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Calculate number of days
            int duration =
                (endDate - startDate).Days;

            try
            {
                // Get data from database
                List<Crop> crops =
                    cropRepository.GetSuggestedCrops(
                        location,
                        duration);

                // Remove previous results
                flpResults.Controls.Clear();

                // No crop found
                if (crops.Count == 0)
                {
                    Label noResult = new Label();

                    noResult.Text =
                        "No suitable crop found for " +
                        location +
                        " and " +
                        duration +
                        " days.";

                    noResult.Font =
                        new Font("Arial", 12);

                    noResult.AutoSize = true;

                    noResult.Margin =
                        new Padding(10);

                    flpResults.Controls.Add(noResult);

                    return;
                }

                // Display results
                foreach (Crop crop in crops)
                {
                    Panel card =
                        CreateCropCard(crop, duration);

                    flpResults.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to connect to the database.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
        private Panel CreateCropCard(
            Crop crop,
            int duration)
        {
            Panel card = new Panel();

            card.Width = 700;
            card.Height = 180;
            card.BorderStyle =
                BorderStyle.FixedSingle;
            card.Margin =
                new Padding(5);

            Label name = new Label();

            name.Text =
                "🌱 " + crop.CropName;

            name.Font =
                new Font(
                    "Arial",
                    16,
                    FontStyle.Bold);

            name.Location =
                new Point(15, 10);

            name.AutoSize = true;

            card.Controls.Add(name);


            Label location = new Label();

            location.Text =
                "Suitable Location: " +
                crop.SuitableLocation;

            location.Location =
                new Point(15, 45);

            location.AutoSize = true;

            card.Controls.Add(location);


            Label growingPeriod = new Label();

            growingPeriod.Text =
                "Growing Period: " +
                crop.MinDurationDays +
                " - " +
                crop.MaxDurationDays +
                " days";

            growingPeriod.Location =
                new Point(15, 70);

            growingPeriod.AutoSize = true;

            card.Controls.Add(growingPeriod);


            Label selectedPeriod = new Label();

            selectedPeriod.Text =
                "Your Selected Period: " +
                duration +
                " days ✓";

            selectedPeriod.Location =
                new Point(15, 95);

            selectedPeriod.AutoSize = true;

            card.Controls.Add(selectedPeriod);


            Label soil = new Label();

            soil.Text =
                "Suitable Soil: " +
                crop.SuitableSoil;

            soil.Location =
                new Point(15, 120);

            soil.AutoSize = true;

            card.Controls.Add(soil);


            Label description = new Label();

            description.Text =
                "Description: " +
                crop.Description;

            description.Location =
                new Point(15, 145);

            description.Width = 650;

            description.Height = 30;

            card.Controls.Add(description);

            return card;
        }
    }
}
