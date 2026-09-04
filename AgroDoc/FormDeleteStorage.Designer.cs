namespace AgroDoc
{
    partial class FormDeleteStorage
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
            this.dgvDeleteView = new System.Windows.Forms.DataGridView();
            this.lblSelectCat = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeleteView
            // 
            this.dgvDeleteView.AllowUserToAddRows = false;
            this.dgvDeleteView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeleteView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteView.Location = new System.Drawing.Point(58, 189);
            this.dgvDeleteView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDeleteView.Name = "dgvDeleteView";
            this.dgvDeleteView.ReadOnly = true;
            this.dgvDeleteView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeleteView.Size = new System.Drawing.Size(1053, 406);
            this.dgvDeleteView.TabIndex = 0;
            // 
            // lblSelectCat
            // 
            this.lblSelectCat.AutoSize = true;
            this.lblSelectCat.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCat.Location = new System.Drawing.Point(476, 78);
            this.lblSelectCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectCat.Name = "lblSelectCat";
            this.lblSelectCat.Size = new System.Drawing.Size(216, 23);
            this.lblSelectCat.TabIndex = 1;
            this.lblSelectCat.Text = "Select Storage Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(464, 117);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(244, 28);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(267, 631);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(230, 68);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to Storage";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(645, 631);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(230, 68);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Selected Record";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormDeleteStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 740);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblSelectCat);
            this.Controls.Add(this.dgvDeleteView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDeleteStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgroDoc - Delete Storage Records";
            this.Load += new System.EventHandler(this.FormDeleteStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeleteView;
        private System.Windows.Forms.Label lblSelectCat;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
    }
}