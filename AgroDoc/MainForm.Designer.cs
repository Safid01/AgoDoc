namespace AgroDoc
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSoilIndex = new System.Windows.Forms.Button();
            this.btnCropSuggestion = new System.Windows.Forms.Button();
            this.btnFertilizer = new System.Windows.Forms.Button();
            this.btnStorageTracker = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSoilIndex
            // 
            this.btnSoilIndex.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSoilIndex.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoilIndex.Location = new System.Drawing.Point(37, 183);
            this.btnSoilIndex.Name = "btnSoilIndex";
            this.btnSoilIndex.Size = new System.Drawing.Size(149, 65);
            this.btnSoilIndex.TabIndex = 0;
            this.btnSoilIndex.Text = "Soil Index";
            this.btnSoilIndex.UseVisualStyleBackColor = false;
            this.btnSoilIndex.Click += new System.EventHandler(this.btnSoilIndex_Click);
            // 
            // btnCropSuggestion
            // 
            this.btnCropSuggestion.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCropSuggestion.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCropSuggestion.Location = new System.Drawing.Point(37, 305);
            this.btnCropSuggestion.Name = "btnCropSuggestion";
            this.btnCropSuggestion.Size = new System.Drawing.Size(149, 65);
            this.btnCropSuggestion.TabIndex = 1;
            this.btnCropSuggestion.Text = "Crop Suggestion";
            this.btnCropSuggestion.UseVisualStyleBackColor = false;
            this.btnCropSuggestion.Click += new System.EventHandler(this.btnCropSuggestion_Click);
            // 
            // btnFertilizer
            // 
            this.btnFertilizer.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnFertilizer.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFertilizer.Location = new System.Drawing.Point(648, 183);
            this.btnFertilizer.Name = "btnFertilizer";
            this.btnFertilizer.Size = new System.Drawing.Size(149, 65);
            this.btnFertilizer.TabIndex = 2;
            this.btnFertilizer.Text = "Fertilizer Suggestion";
            this.btnFertilizer.UseVisualStyleBackColor = false;
            this.btnFertilizer.Click += new System.EventHandler(this.btnFertilizer_Click);
            // 
            // btnStorageTracker
            // 
            this.btnStorageTracker.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnStorageTracker.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorageTracker.Location = new System.Drawing.Point(648, 305);
            this.btnStorageTracker.Name = "btnStorageTracker";
            this.btnStorageTracker.Size = new System.Drawing.Size(149, 65);
            this.btnStorageTracker.TabIndex = 3;
            this.btnStorageTracker.Text = "Storage Tracker";
            this.btnStorageTracker.UseVisualStyleBackColor = false;
            this.btnStorageTracker.Click += new System.EventHandler(this.btnStorageTracker_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLogout.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(747, 35);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Sign out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(12, 35);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AgroDoc.Properties.Resources.Gemini_Generated_Image_pgfm7ypgfm7ypgfm_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(195, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.ForestGreen;
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Controls.Add(this.btnLogout);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(834, 90);
            this.panelHeader.TabIndex = 8;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblWelcome.Location = new System.Drawing.Point(191, 34);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(338, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Farmer | Location: ---";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 501);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStorageTracker);
            this.Controls.Add(this.btnFertilizer);
            this.Controls.Add(this.btnCropSuggestion);
            this.Controls.Add(this.btnSoilIndex);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgroDoc - ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSoilIndex;
        private System.Windows.Forms.Button btnCropSuggestion;
        private System.Windows.Forms.Button btnFertilizer;
        private System.Windows.Forms.Button btnStorageTracker;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;
    }
}