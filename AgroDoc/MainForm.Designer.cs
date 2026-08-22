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
            this.btnSoilManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoilManagement
            // 
            this.btnSoilManagement.Location = new System.Drawing.Point(85, 145);
            this.btnSoilManagement.Name = "btnSoilManagement";
            this.btnSoilManagement.Size = new System.Drawing.Size(251, 39);
            this.btnSoilManagement.TabIndex = 0;
            this.btnSoilManagement.Text = "Soil Management";
            this.btnSoilManagement.UseVisualStyleBackColor = true;
            this.btnSoilManagement.Click += new System.EventHandler(this.btnSoilManagement_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSoilManagement);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSoilManagement;
    }
}