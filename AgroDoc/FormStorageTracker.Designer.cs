namespace AgroDoc
{
    partial class FormStorageTracker
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
            this.btnGoToDelete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFertilizer = new System.Windows.Forms.TabPage();
            this.dgvFertilizerStock = new System.Windows.Forms.DataGridView();
            this.grpFertOps = new System.Windows.Forms.GroupBox();
            this.btnSaveFertilizer = new System.Windows.Forms.Button();
            this.txtFertQuantity = new System.Windows.Forms.TextBox();
            this.lblFertQty = new System.Windows.Forms.Label();
            this.rbUse = new System.Windows.Forms.RadioButton();
            this.rbRestock = new System.Windows.Forms.RadioButton();
            this.cmbFertilizerName = new System.Windows.Forms.ComboBox();
            this.lblFertName = new System.Windows.Forms.Label();
            this.tabHarvest = new System.Windows.Forms.TabPage();
            this.dgvHarvestStock = new System.Windows.Forms.DataGridView();
            this.grpHarvestOps = new System.Windows.Forms.GroupBox();
            this.txtHarvestNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtStorageLocation = new System.Windows.Forms.TextBox();
            this.lblStorageLoc = new System.Windows.Forms.Label();
            this.dtpHarvestDate = new System.Windows.Forms.DateTimePicker();
            this.lblHarvestDate = new System.Windows.Forms.Label();
            this.txtHarvestQuantity = new System.Windows.Forms.TextBox();
            this.lblHarvestQty = new System.Windows.Forms.Label();
            this.cmbHarvestCrop = new System.Windows.Forms.ComboBox();
            this.lblCropName = new System.Windows.Forms.Label();
            this.btnSaveHarvest = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabFertilizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFertilizerStock)).BeginInit();
            this.grpFertOps.SuspendLayout();
            this.tabHarvest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHarvestStock)).BeginInit();
            this.grpHarvestOps.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoToDelete
            // 
            this.btnGoToDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGoToDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGoToDelete.Location = new System.Drawing.Point(722, 23);
            this.btnGoToDelete.Name = "btnGoToDelete";
            this.btnGoToDelete.Size = new System.Drawing.Size(109, 44);
            this.btnGoToDelete.TabIndex = 0;
            this.btnGoToDelete.Text = "Delete Entries";
            this.btnGoToDelete.UseVisualStyleBackColor = false;
            this.btnGoToDelete.Click += new System.EventHandler(this.btnGoToDelete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFertilizer);
            this.tabControl1.Controls.Add(this.tabHarvest);
            this.tabControl1.Location = new System.Drawing.Point(10, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 553);
            this.tabControl1.TabIndex = 1;
            // 
            // tabFertilizer
            // 
            this.tabFertilizer.Controls.Add(this.dgvFertilizerStock);
            this.tabFertilizer.Controls.Add(this.grpFertOps);
            this.tabFertilizer.Location = new System.Drawing.Point(4, 22);
            this.tabFertilizer.Name = "tabFertilizer";
            this.tabFertilizer.Padding = new System.Windows.Forms.Padding(3);
            this.tabFertilizer.Size = new System.Drawing.Size(823, 527);
            this.tabFertilizer.TabIndex = 0;
            this.tabFertilizer.Text = "Fertilizer Inventory";
            this.tabFertilizer.UseVisualStyleBackColor = true;
            // 
            // dgvFertilizerStock
            // 
            this.dgvFertilizerStock.AllowUserToAddRows = false;
            this.dgvFertilizerStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFertilizerStock.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvFertilizerStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFertilizerStock.Location = new System.Drawing.Point(19, 124);
            this.dgvFertilizerStock.Name = "dgvFertilizerStock";
            this.dgvFertilizerStock.ReadOnly = true;
            this.dgvFertilizerStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFertilizerStock.Size = new System.Drawing.Size(798, 397);
            this.dgvFertilizerStock.TabIndex = 1;
            // 
            // grpFertOps
            // 
            this.grpFertOps.Controls.Add(this.btnSaveFertilizer);
            this.grpFertOps.Controls.Add(this.txtFertQuantity);
            this.grpFertOps.Controls.Add(this.lblFertQty);
            this.grpFertOps.Controls.Add(this.rbUse);
            this.grpFertOps.Controls.Add(this.rbRestock);
            this.grpFertOps.Controls.Add(this.cmbFertilizerName);
            this.grpFertOps.Controls.Add(this.lblFertName);
            this.grpFertOps.Location = new System.Drawing.Point(19, 20);
            this.grpFertOps.Name = "grpFertOps";
            this.grpFertOps.Size = new System.Drawing.Size(566, 98);
            this.grpFertOps.TabIndex = 0;
            this.grpFertOps.TabStop = false;
            this.grpFertOps.Text = "Update Fertilizer Stock";
            // 
            // btnSaveFertilizer
            // 
            this.btnSaveFertilizer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveFertilizer.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFertilizer.Location = new System.Drawing.Point(444, 31);
            this.btnSaveFertilizer.Name = "btnSaveFertilizer";
            this.btnSaveFertilizer.Size = new System.Drawing.Size(90, 41);
            this.btnSaveFertilizer.TabIndex = 6;
            this.btnSaveFertilizer.Text = "Update Stock";
            this.btnSaveFertilizer.UseVisualStyleBackColor = false;
            this.btnSaveFertilizer.Click += new System.EventHandler(this.btnSaveFertilizer_Click);
            // 
            // txtFertQuantity
            // 
            this.txtFertQuantity.Location = new System.Drawing.Point(324, 52);
            this.txtFertQuantity.Name = "txtFertQuantity";
            this.txtFertQuantity.Size = new System.Drawing.Size(70, 20);
            this.txtFertQuantity.TabIndex = 5;
            this.txtFertQuantity.Text = "0";
            // 
            // lblFertQty
            // 
            this.lblFertQty.AutoSize = true;
            this.lblFertQty.Location = new System.Drawing.Point(321, 25);
            this.lblFertQty.Name = "lblFertQty";
            this.lblFertQty.Size = new System.Drawing.Size(73, 13);
            this.lblFertQty.TabIndex = 4;
            this.lblFertQty.Text = "Quantity (KG):";
            // 
            // rbUse
            // 
            this.rbUse.AutoSize = true;
            this.rbUse.Location = new System.Drawing.Point(210, 56);
            this.rbUse.Name = "rbUse";
            this.rbUse.Size = new System.Drawing.Size(50, 17);
            this.rbUse.TabIndex = 3;
            this.rbUse.TabStop = true;
            this.rbUse.Text = "Used";
            this.rbUse.UseVisualStyleBackColor = true;
            // 
            // rbRestock
            // 
            this.rbRestock.AutoSize = true;
            this.rbRestock.Location = new System.Drawing.Point(210, 25);
            this.rbRestock.Name = "rbRestock";
            this.rbRestock.Size = new System.Drawing.Size(77, 17);
            this.rbRestock.TabIndex = 2;
            this.rbRestock.TabStop = true;
            this.rbRestock.Text = "Restocked";
            this.rbRestock.UseVisualStyleBackColor = true;
            // 
            // cmbFertilizerName
            // 
            this.cmbFertilizerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFertilizerName.FormattingEnabled = true;
            this.cmbFertilizerName.Location = new System.Drawing.Point(24, 52);
            this.cmbFertilizerName.Name = "cmbFertilizerName";
            this.cmbFertilizerName.Size = new System.Drawing.Size(142, 21);
            this.cmbFertilizerName.TabIndex = 1;
            // 
            // lblFertName
            // 
            this.lblFertName.AutoSize = true;
            this.lblFertName.Location = new System.Drawing.Point(21, 25);
            this.lblFertName.Name = "lblFertName";
            this.lblFertName.Size = new System.Drawing.Size(48, 13);
            this.lblFertName.TabIndex = 0;
            this.lblFertName.Text = "Fertilizer:";
            // 
            // tabHarvest
            // 
            this.tabHarvest.Controls.Add(this.dgvHarvestStock);
            this.tabHarvest.Controls.Add(this.grpHarvestOps);
            this.tabHarvest.Location = new System.Drawing.Point(4, 22);
            this.tabHarvest.Name = "tabHarvest";
            this.tabHarvest.Padding = new System.Windows.Forms.Padding(3);
            this.tabHarvest.Size = new System.Drawing.Size(823, 527);
            this.tabHarvest.TabIndex = 1;
            this.tabHarvest.Text = "Harvest Log";
            this.tabHarvest.UseVisualStyleBackColor = true;
            // 
            // dgvHarvestStock
            // 
            this.dgvHarvestStock.AllowUserToAddRows = false;
            this.dgvHarvestStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHarvestStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHarvestStock.Location = new System.Drawing.Point(20, 123);
            this.dgvHarvestStock.Name = "dgvHarvestStock";
            this.dgvHarvestStock.ReadOnly = true;
            this.dgvHarvestStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHarvestStock.Size = new System.Drawing.Size(781, 380);
            this.dgvHarvestStock.TabIndex = 1;
            // 
            // grpHarvestOps
            // 
            this.grpHarvestOps.Controls.Add(this.btnSaveHarvest);
            this.grpHarvestOps.Controls.Add(this.txtHarvestNotes);
            this.grpHarvestOps.Controls.Add(this.lblNotes);
            this.grpHarvestOps.Controls.Add(this.txtStorageLocation);
            this.grpHarvestOps.Controls.Add(this.lblStorageLoc);
            this.grpHarvestOps.Controls.Add(this.dtpHarvestDate);
            this.grpHarvestOps.Controls.Add(this.lblHarvestDate);
            this.grpHarvestOps.Controls.Add(this.txtHarvestQuantity);
            this.grpHarvestOps.Controls.Add(this.lblHarvestQty);
            this.grpHarvestOps.Controls.Add(this.cmbHarvestCrop);
            this.grpHarvestOps.Controls.Add(this.lblCropName);
            this.grpHarvestOps.Location = new System.Drawing.Point(20, 20);
            this.grpHarvestOps.Name = "grpHarvestOps";
            this.grpHarvestOps.Size = new System.Drawing.Size(781, 97);
            this.grpHarvestOps.TabIndex = 0;
            this.grpHarvestOps.TabStop = false;
            this.grpHarvestOps.Text = "Log New Harvest Entry";
            // 
            // txtHarvestNotes
            // 
            this.txtHarvestNotes.Location = new System.Drawing.Point(510, 27);
            this.txtHarvestNotes.Name = "txtHarvestNotes";
            this.txtHarvestNotes.Size = new System.Drawing.Size(176, 61);
            this.txtHarvestNotes.TabIndex = 9;
            this.txtHarvestNotes.Text = "Good moisture condition";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(507, 11);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(81, 13);
            this.lblNotes.TabIndex = 8;
            this.lblNotes.Text = "Notes / Quality:";
            // 
            // txtStorageLocation
            // 
            this.txtStorageLocation.Location = new System.Drawing.Point(391, 53);
            this.txtStorageLocation.Name = "txtStorageLocation";
            this.txtStorageLocation.Size = new System.Drawing.Size(100, 20);
            this.txtStorageLocation.TabIndex = 7;
            this.txtStorageLocation.Text = "Main Werehouse";
            // 
            // lblStorageLoc
            // 
            this.lblStorageLoc.AutoSize = true;
            this.lblStorageLoc.Location = new System.Drawing.Point(388, 26);
            this.lblStorageLoc.Name = "lblStorageLoc";
            this.lblStorageLoc.Size = new System.Drawing.Size(91, 13);
            this.lblStorageLoc.TabIndex = 6;
            this.lblStorageLoc.Text = "Storage Location:";
            // 
            // dtpHarvestDate
            // 
            this.dtpHarvestDate.Location = new System.Drawing.Point(252, 53);
            this.dtpHarvestDate.Name = "dtpHarvestDate";
            this.dtpHarvestDate.Size = new System.Drawing.Size(118, 20);
            this.dtpHarvestDate.TabIndex = 5;
            // 
            // lblHarvestDate
            // 
            this.lblHarvestDate.AutoSize = true;
            this.lblHarvestDate.Location = new System.Drawing.Point(249, 26);
            this.lblHarvestDate.Name = "lblHarvestDate";
            this.lblHarvestDate.Size = new System.Drawing.Size(85, 13);
            this.lblHarvestDate.TabIndex = 4;
            this.lblHarvestDate.Text = "Date Harvested:";
            // 
            // txtHarvestQuantity
            // 
            this.txtHarvestQuantity.Location = new System.Drawing.Point(139, 53);
            this.txtHarvestQuantity.Name = "txtHarvestQuantity";
            this.txtHarvestQuantity.Size = new System.Drawing.Size(96, 20);
            this.txtHarvestQuantity.TabIndex = 3;
            this.txtHarvestQuantity.Text = "0";
            // 
            // lblHarvestQty
            // 
            this.lblHarvestQty.AutoSize = true;
            this.lblHarvestQty.Location = new System.Drawing.Point(136, 26);
            this.lblHarvestQty.Name = "lblHarvestQty";
            this.lblHarvestQty.Size = new System.Drawing.Size(99, 13);
            this.lblHarvestQty.TabIndex = 2;
            this.lblHarvestQty.Text = "Yield Quantity (KG):";
            // 
            // cmbHarvestCrop
            // 
            this.cmbHarvestCrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHarvestCrop.FormattingEnabled = true;
            this.cmbHarvestCrop.Location = new System.Drawing.Point(23, 53);
            this.cmbHarvestCrop.Name = "cmbHarvestCrop";
            this.cmbHarvestCrop.Size = new System.Drawing.Size(101, 21);
            this.cmbHarvestCrop.TabIndex = 1;
            // 
            // lblCropName
            // 
            this.lblCropName.AutoSize = true;
            this.lblCropName.Location = new System.Drawing.Point(20, 26);
            this.lblCropName.Name = "lblCropName";
            this.lblCropName.Size = new System.Drawing.Size(84, 13);
            this.lblCropName.TabIndex = 0;
            this.lblCropName.Text = "Harvested Crop:";
            // 
            // btnSaveHarvest
            // 
            this.btnSaveHarvest.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveHarvest.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveHarvest.Location = new System.Drawing.Point(699, 27);
            this.btnSaveHarvest.Name = "btnSaveHarvest";
            this.btnSaveHarvest.Size = new System.Drawing.Size(76, 46);
            this.btnSaveHarvest.TabIndex = 10;
            this.btnSaveHarvest.Text = "Record Harvest";
            this.btnSaveHarvest.UseVisualStyleBackColor = false;
            this.btnSaveHarvest.Click += new System.EventHandler(this.btnSaveHarvest_Click_1);
            // 
            // FormStorageTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(846, 630);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnGoToDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormStorageTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgroDoc - Farm Storage & Inventory Tracker";
            this.Load += new System.EventHandler(this.FormStorageTracker_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabFertilizer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFertilizerStock)).EndInit();
            this.grpFertOps.ResumeLayout(false);
            this.grpFertOps.PerformLayout();
            this.tabHarvest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHarvestStock)).EndInit();
            this.grpHarvestOps.ResumeLayout(false);
            this.grpHarvestOps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToDelete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFertilizer;
        private System.Windows.Forms.TabPage tabHarvest;
        private System.Windows.Forms.GroupBox grpFertOps;
        private System.Windows.Forms.RadioButton rbUse;
        private System.Windows.Forms.RadioButton rbRestock;
        private System.Windows.Forms.ComboBox cmbFertilizerName;
        private System.Windows.Forms.Label lblFertName;
        private System.Windows.Forms.GroupBox grpHarvestOps;
        private System.Windows.Forms.Button btnSaveFertilizer;
        private System.Windows.Forms.TextBox txtFertQuantity;
        private System.Windows.Forms.Label lblFertQty;
        private System.Windows.Forms.DataGridView dgvFertilizerStock;
        private System.Windows.Forms.Label lblCropName;
        private System.Windows.Forms.Label lblHarvestQty;
        private System.Windows.Forms.ComboBox cmbHarvestCrop;
        private System.Windows.Forms.Label lblHarvestDate;
        private System.Windows.Forms.TextBox txtHarvestQuantity;
        private System.Windows.Forms.DateTimePicker dtpHarvestDate;
        private System.Windows.Forms.Label lblStorageLoc;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtStorageLocation;
        private System.Windows.Forms.RichTextBox txtHarvestNotes;
        private System.Windows.Forms.DataGridView dgvHarvestStock;
        private System.Windows.Forms.Button btnSaveHarvest;
    }
}