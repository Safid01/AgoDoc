namespace AgroDoc
{
    partial class FormCropSuggestion
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
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSuggestCrop = new System.Windows.Forms.Button();
            this.lblSuggestedCrops = new System.Windows.Forms.Label();
            this.flpResults = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Font = new System.Drawing.Font("Georgia", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSubTitle.Location = new System.Drawing.Point(411, 29);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(243, 31);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Crop Suggestion";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(17, 148);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(71, 18);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(147, 148);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(215, 26);
            this.txtLocation.TabIndex = 3;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(17, 206);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(80, 18);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Georgia", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(350, 206);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(75, 18);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(147, 206);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(151, 26);
            this.dtpStartDate.TabIndex = 6;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(486, 208);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(151, 26);
            this.dtpEndDate.TabIndex = 7;
            // 
            // btnSuggestCrop
            // 
            this.btnSuggestCrop.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSuggestCrop.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuggestCrop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSuggestCrop.Location = new System.Drawing.Point(752, 198);
            this.btnSuggestCrop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuggestCrop.Name = "btnSuggestCrop";
            this.btnSuggestCrop.Size = new System.Drawing.Size(249, 42);
            this.btnSuggestCrop.TabIndex = 8;
            this.btnSuggestCrop.Text = "Suggest Crops";
            this.btnSuggestCrop.UseVisualStyleBackColor = false;
            this.btnSuggestCrop.Click += new System.EventHandler(this.btnSuggestCrop_Click);
            // 
            // lblSuggestedCrops
            // 
            this.lblSuggestedCrops.AutoSize = true;
            this.lblSuggestedCrops.BackColor = System.Drawing.Color.Transparent;
            this.lblSuggestedCrops.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestedCrops.Location = new System.Drawing.Point(32, 318);
            this.lblSuggestedCrops.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuggestedCrops.Name = "lblSuggestedCrops";
            this.lblSuggestedCrops.Size = new System.Drawing.Size(119, 15);
            this.lblSuggestedCrops.TabIndex = 9;
            this.lblSuggestedCrops.Text = "Suggested Crops :";
            // 
            // flpResults
            // 
            this.flpResults.AutoScroll = true;
            this.flpResults.BackColor = System.Drawing.SystemColors.Info;
            this.flpResults.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpResults.Font = new System.Drawing.Font("Corbel", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpResults.Location = new System.Drawing.Point(26, 357);
            this.flpResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpResults.Name = "flpResults";
            this.flpResults.Size = new System.Drawing.Size(1037, 254);
            this.flpResults.TabIndex = 10;
            this.flpResults.WrapContents = false;
            this.flpResults.Paint += new System.Windows.Forms.PaintEventHandler(this.flpResults_Paint);
            // 
            // FormCropSuggestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1079, 640);
            this.Controls.Add(this.flpResults);
            this.Controls.Add(this.lblSuggestedCrops);
            this.Controls.Add(this.btnSuggestCrop);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblSubTitle);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormCropSuggestion";
            this.Text = "AgroDoc - Crop Suggestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnSuggestCrop;
        private System.Windows.Forms.Label lblSuggestedCrops;
        private System.Windows.Forms.FlowLayoutPanel flpResults;
    }
}