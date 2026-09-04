namespace AgroDoc
{
    partial class FormSoilIndex
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnLoadLatest = new System.Windows.Forms.Button();
            this.btnSaveEvaluate = new System.Windows.Forms.Button();
            this.txtPh = new System.Windows.Forms.TextBox();
            this.lblPh = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.lblK = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.lblP = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.cmbSoilType = new System.Windows.Forms.ComboBox();
            this.lblSoilType = new System.Windows.Forms.Label();
            this.lblHistoryHeader = new System.Windows.Forms.Label();
            this.dgvSoilHistory = new System.Windows.Forms.DataGridView();
            this.chartSoilNPK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblHealthTitle = new System.Windows.Forms.Label();
            this.lblHealthBadge = new System.Windows.Forms.Label();
            this.lblDoctorHeader = new System.Windows.Forms.Label();
            this.txtDoctorComments = new System.Windows.Forms.TextBox();
            this.btnGoToFertilizer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoilHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoilNPK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(480, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(487, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🌿 Soil Health Index And Management";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInput
            // 
            this.grpInput.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.grpInput.BackColor = System.Drawing.Color.Transparent;
            this.grpInput.Controls.Add(this.btnLoadLatest);
            this.grpInput.Controls.Add(this.btnSaveEvaluate);
            this.grpInput.Controls.Add(this.txtPh);
            this.grpInput.Controls.Add(this.lblPh);
            this.grpInput.Controls.Add(this.txtK);
            this.grpInput.Controls.Add(this.lblK);
            this.grpInput.Controls.Add(this.txtP);
            this.grpInput.Controls.Add(this.lblP);
            this.grpInput.Controls.Add(this.txtN);
            this.grpInput.Controls.Add(this.lblN);
            this.grpInput.Controls.Add(this.cmbSoilType);
            this.grpInput.Controls.Add(this.lblSoilType);
            this.grpInput.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.ForeColor = System.Drawing.Color.White;
            this.grpInput.Location = new System.Drawing.Point(23, 54);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(402, 369);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Log Soil Sample";
            // 
            // btnLoadLatest
            // 
            this.btnLoadLatest.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLoadLatest.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadLatest.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadLatest.Location = new System.Drawing.Point(25, 308);
            this.btnLoadLatest.Name = "btnLoadLatest";
            this.btnLoadLatest.Size = new System.Drawing.Size(341, 39);
            this.btnLoadLatest.TabIndex = 11;
            this.btnLoadLatest.Text = "📂 Load Latest Record";
            this.btnLoadLatest.UseVisualStyleBackColor = false;
            this.btnLoadLatest.Click += new System.EventHandler(this.btnLoadLatest_Click);
            // 
            // btnSaveEvaluate
            // 
            this.btnSaveEvaluate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveEvaluate.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEvaluate.ForeColor = System.Drawing.Color.White;
            this.btnSaveEvaluate.Location = new System.Drawing.Point(25, 261);
            this.btnSaveEvaluate.Name = "btnSaveEvaluate";
            this.btnSaveEvaluate.Size = new System.Drawing.Size(341, 39);
            this.btnSaveEvaluate.TabIndex = 10;
            this.btnSaveEvaluate.Text = "💾 Save N Evaluate Soil";
            this.btnSaveEvaluate.UseVisualStyleBackColor = false;
            this.btnSaveEvaluate.Click += new System.EventHandler(this.btnSaveEvaluate_Click);
            // 
            // txtPh
            // 
            this.txtPh.Location = new System.Drawing.Point(275, 212);
            this.txtPh.Name = "txtPh";
            this.txtPh.Size = new System.Drawing.Size(91, 28);
            this.txtPh.TabIndex = 9;
            // 
            // lblPh
            // 
            this.lblPh.AutoSize = true;
            this.lblPh.BackColor = System.Drawing.Color.Transparent;
            this.lblPh.ForeColor = System.Drawing.Color.Black;
            this.lblPh.Location = new System.Drawing.Point(21, 212);
            this.lblPh.Name = "lblPh";
            this.lblPh.Size = new System.Drawing.Size(192, 23);
            this.lblPh.TabIndex = 8;
            this.lblPh.Text = "Soil pH Level (0 - 14):";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(275, 172);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(91, 28);
            this.txtK.TabIndex = 7;
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.BackColor = System.Drawing.Color.Transparent;
            this.lblK.ForeColor = System.Drawing.Color.Black;
            this.lblK.Location = new System.Drawing.Point(21, 175);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(209, 23);
            this.lblK.TabIndex = 6;
            this.lblK.Text = "Potassium (K - ppm/kg):";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(275, 132);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(91, 28);
            this.txtP.TabIndex = 5;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.BackColor = System.Drawing.Color.Transparent;
            this.lblP.ForeColor = System.Drawing.Color.Black;
            this.lblP.Location = new System.Drawing.Point(21, 135);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(223, 23);
            this.lblP.TabIndex = 4;
            this.lblP.Text = "Phosphorus (P - ppm/kg):";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(275, 98);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(91, 28);
            this.txtN.TabIndex = 3;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.BackColor = System.Drawing.Color.Transparent;
            this.lblN.ForeColor = System.Drawing.Color.Black;
            this.lblN.Location = new System.Drawing.Point(21, 101);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(198, 23);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "Nitrogen (N - ppm/kg):";
            // 
            // cmbSoilType
            // 
            this.cmbSoilType.FormattingEnabled = true;
            this.cmbSoilType.Items.AddRange(new object[] {
            "Loamy",
            "Clay Loam",
            "Sandy Loam",
            "Clay",
            "Alluvial",
            "Sandy"});
            this.cmbSoilType.Location = new System.Drawing.Point(88, 44);
            this.cmbSoilType.Name = "cmbSoilType";
            this.cmbSoilType.Size = new System.Drawing.Size(278, 31);
            this.cmbSoilType.TabIndex = 1;
            // 
            // lblSoilType
            // 
            this.lblSoilType.AutoSize = true;
            this.lblSoilType.BackColor = System.Drawing.Color.Transparent;
            this.lblSoilType.ForeColor = System.Drawing.Color.Black;
            this.lblSoilType.Location = new System.Drawing.Point(21, 47);
            this.lblSoilType.Name = "lblSoilType";
            this.lblSoilType.Size = new System.Drawing.Size(57, 23);
            this.lblSoilType.TabIndex = 0;
            this.lblSoilType.Text = "Type:";
            // 
            // lblHistoryHeader
            // 
            this.lblHistoryHeader.AutoSize = true;
            this.lblHistoryHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHistoryHeader.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryHeader.ForeColor = System.Drawing.Color.White;
            this.lblHistoryHeader.Location = new System.Drawing.Point(19, 456);
            this.lblHistoryHeader.Name = "lblHistoryHeader";
            this.lblHistoryHeader.Size = new System.Drawing.Size(204, 26);
            this.lblHistoryHeader.TabIndex = 12;
            this.lblHistoryHeader.Text = "📋 Soil Test History:";
            this.lblHistoryHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSoilHistory
            // 
            this.dgvSoilHistory.AllowUserToAddRows = false;
            this.dgvSoilHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoilHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvSoilHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoilHistory.Location = new System.Drawing.Point(23, 495);
            this.dgvSoilHistory.Name = "dgvSoilHistory";
            this.dgvSoilHistory.ReadOnly = true;
            this.dgvSoilHistory.RowHeadersWidth = 62;
            this.dgvSoilHistory.RowTemplate.Height = 28;
            this.dgvSoilHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoilHistory.Size = new System.Drawing.Size(784, 269);
            this.dgvSoilHistory.TabIndex = 13;
            // 
            // chartSoilNPK
            // 
            chartArea1.Name = "SoilArea";
            this.chartSoilNPK.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSoilNPK.Legends.Add(legend1);
            this.chartSoilNPK.Location = new System.Drawing.Point(840, 54);
            this.chartSoilNPK.Name = "chartSoilNPK";
            this.chartSoilNPK.Size = new System.Drawing.Size(521, 369);
            this.chartSoilNPK.TabIndex = 14;
            this.chartSoilNPK.Text = "chartSoilNPK";
            // 
            // lblHealthTitle
            // 
            this.lblHealthTitle.AutoSize = true;
            this.lblHealthTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHealthTitle.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthTitle.ForeColor = System.Drawing.Color.White;
            this.lblHealthTitle.Location = new System.Drawing.Point(835, 456);
            this.lblHealthTitle.Name = "lblHealthTitle";
            this.lblHealthTitle.Size = new System.Drawing.Size(190, 26);
            this.lblHealthTitle.TabIndex = 15;
            this.lblHealthTitle.Text = "Overall Soil Status:";
            this.lblHealthTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHealthBadge
            // 
            this.lblHealthBadge.AutoSize = true;
            this.lblHealthBadge.BackColor = System.Drawing.Color.Transparent;
            this.lblHealthBadge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthBadge.ForeColor = System.Drawing.Color.Red;
            this.lblHealthBadge.Location = new System.Drawing.Point(1061, 456);
            this.lblHealthBadge.Name = "lblHealthBadge";
            this.lblHealthBadge.Size = new System.Drawing.Size(260, 26);
            this.lblHealthBadge.TabIndex = 16;
            this.lblHealthBadge.Text = "No Soil Data Evaluated";
            this.lblHealthBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoctorHeader
            // 
            this.lblDoctorHeader.AutoSize = true;
            this.lblDoctorHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctorHeader.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorHeader.ForeColor = System.Drawing.Color.White;
            this.lblDoctorHeader.Location = new System.Drawing.Point(836, 495);
            this.lblDoctorHeader.Name = "lblDoctorHeader";
            this.lblDoctorHeader.Size = new System.Drawing.Size(332, 23);
            this.lblDoctorHeader.TabIndex = 17;
            this.lblDoctorHeader.Text = "🩺 Agro Doctor Diagnostic Assessment:\r\n";
            this.lblDoctorHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDoctorComments
            // 
            this.txtDoctorComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDoctorComments.Location = new System.Drawing.Point(849, 524);
            this.txtDoctorComments.Multiline = true;
            this.txtDoctorComments.Name = "txtDoctorComments";
            this.txtDoctorComments.ReadOnly = true;
            this.txtDoctorComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDoctorComments.Size = new System.Drawing.Size(512, 166);
            this.txtDoctorComments.TabIndex = 18;
            // 
            // btnGoToFertilizer
            // 
            this.btnGoToFertilizer.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGoToFertilizer.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToFertilizer.ForeColor = System.Drawing.Color.White;
            this.btnGoToFertilizer.Location = new System.Drawing.Point(879, 702);
            this.btnGoToFertilizer.Name = "btnGoToFertilizer";
            this.btnGoToFertilizer.Size = new System.Drawing.Size(430, 62);
            this.btnGoToFertilizer.TabIndex = 19;
            this.btnGoToFertilizer.Text = "🧪 Open Fertilizer Suggestions for this Soil >";
            this.btnGoToFertilizer.UseVisualStyleBackColor = false;
            this.btnGoToFertilizer.Click += new System.EventHandler(this.btnGoToFertilizer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgroDoc.Properties.Resources.Gemini_Generated_Image_pgfm7ypgfm7ypgfm_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(395, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FormSoilIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1386, 792);
            this.Controls.Add(this.btnGoToFertilizer);
            this.Controls.Add(this.txtDoctorComments);
            this.Controls.Add(this.lblDoctorHeader);
            this.Controls.Add(this.lblHealthBadge);
            this.Controls.Add(this.lblHealthTitle);
            this.Controls.Add(this.chartSoilNPK);
            this.Controls.Add(this.dgvSoilHistory);
            this.Controls.Add(this.lblHistoryHeader);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSoilIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSoilManagement";
            this.Load += new System.EventHandler(this.FormSoilIndex_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoilHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoilNPK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.ComboBox cmbSoilType;
        private System.Windows.Forms.Label lblSoilType;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtPh;
        private System.Windows.Forms.Label lblPh;
        private System.Windows.Forms.Button btnSaveEvaluate;
        private System.Windows.Forms.Button btnLoadLatest;
        private System.Windows.Forms.Label lblHistoryHeader;
        private System.Windows.Forms.DataGridView dgvSoilHistory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSoilNPK;
        private System.Windows.Forms.Label lblHealthTitle;
        private System.Windows.Forms.Label lblHealthBadge;
        private System.Windows.Forms.Label lblDoctorHeader;
        private System.Windows.Forms.TextBox txtDoctorComments;
        private System.Windows.Forms.Button btnGoToFertilizer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}