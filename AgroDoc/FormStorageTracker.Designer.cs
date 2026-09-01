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
            this.btnSaveHarvest = new System.Windows.Forms.Button();
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
            this.rbHarvested = new System.Windows.Forms.RadioButton();
            this.rbSold = new System.Windows.Forms.RadioButton();
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
            this.btnGoToDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnGoToDelete.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGoToDelete.Location = new System.Drawing.Point(703, 13);
            this.btnGoToDelete.Name = "btnGoToDelete";
            this.btnGoToDelete.Size = new System.Drawing.Size(128, 44);
            this.btnGoToDelete.TabIndex = 0;
            this.btnGoToDelete.Text = "Delete Entries";
            this.btnGoToDelete.UseVisualStyleBackColor = false;
            this.btnGoToDelete.Click += new System.EventHandler(this.btnGoToDelete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFertilizer);
            this.tabControl1.Controls.Add(this.tabHarvest);
            this.tabControl1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 538);
            this.tabControl1.TabIndex = 1;
            // 
            // tabFertilizer
            // 
            this.tabFertilizer.BackgroundImage = global::AgroDoc.Properties.Resources._3203324;
            this.tabFertilizer.Controls.Add(this.dgvFertilizerStock);
            this.tabFertilizer.Controls.Add(this.grpFertOps);
            this.tabFertilizer.Location = new System.Drawing.Point(4, 25);
            this.tabFertilizer.Name = "tabFertilizer";
            this.tabFertilizer.Padding = new System.Windows.Forms.Padding(3);
            this.tabFertilizer.Size = new System.Drawing.Size(823, 509);
            this.tabFertilizer.TabIndex = 0;
            this.tabFertilizer.Text = "Fertilizer Inventory";
            this.tabFertilizer.UseVisualStyleBackColor = true;
            // 
            // dgvFertilizerStock
            // 
            this.dgvFertilizerStock.AllowUserToAddRows = false;
            this.dgvFertilizerStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFertilizerStock.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dgvFertilizerStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFertilizerStock.Location = new System.Drawing.Point(19, 136);
            this.dgvFertilizerStock.Name = "dgvFertilizerStock";
            this.dgvFertilizerStock.ReadOnly = true;
            this.dgvFertilizerStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFertilizerStock.Size = new System.Drawing.Size(798, 367);
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
            this.grpFertOps.Size = new System.Drawing.Size(691, 110);
            this.grpFertOps.TabIndex = 0;
            this.grpFertOps.TabStop = false;
            this.grpFertOps.Text = "Update Fertilizer Stock";
            // 
            // btnSaveFertilizer
            // 
            this.btnSaveFertilizer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveFertilizer.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFertilizer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveFertilizer.Location = new System.Drawing.Point(537, 37);
            this.btnSaveFertilizer.Name = "btnSaveFertilizer";
            this.btnSaveFertilizer.Size = new System.Drawing.Size(110, 41);
            this.btnSaveFertilizer.TabIndex = 6;
            this.btnSaveFertilizer.Text = "Update Stock";
            this.btnSaveFertilizer.UseVisualStyleBackColor = false;
            this.btnSaveFertilizer.Click += new System.EventHandler(this.btnSaveFertilizer_Click);
            // 
            // txtFertQuantity
            // 
            this.txtFertQuantity.Location = new System.Drawing.Point(406, 52);
            this.txtFertQuantity.Name = "txtFertQuantity";
            this.txtFertQuantity.Size = new System.Drawing.Size(70, 22);
            this.txtFertQuantity.TabIndex = 5;
            this.txtFertQuantity.Text = "0";
            // 
            // lblFertQty
            // 
            this.lblFertQty.AutoSize = true;
            this.lblFertQty.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFertQty.Location = new System.Drawing.Point(403, 24);
            this.lblFertQty.Name = "lblFertQty";
            this.lblFertQty.Size = new System.Drawing.Size(106, 18);
            this.lblFertQty.TabIndex = 4;
            this.lblFertQty.Text = "Quantity (KG):";
            // 
            // rbUse
            // 
            this.rbUse.AutoSize = true;
            this.rbUse.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUse.Location = new System.Drawing.Point(260, 56);
            this.rbUse.Name = "rbUse";
            this.rbUse.Size = new System.Drawing.Size(58, 22);
            this.rbUse.TabIndex = 3;
            this.rbUse.TabStop = true;
            this.rbUse.Text = "Used";
            this.rbUse.UseVisualStyleBackColor = true;
            // 
            // rbRestock
            // 
            this.rbRestock.AutoSize = true;
            this.rbRestock.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRestock.Location = new System.Drawing.Point(260, 24);
            this.rbRestock.Name = "rbRestock";
            this.rbRestock.Size = new System.Drawing.Size(92, 22);
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
            this.cmbFertilizerName.Size = new System.Drawing.Size(195, 24);
            this.cmbFertilizerName.TabIndex = 1;
            // 
            // lblFertName
            // 
            this.lblFertName.AutoSize = true;
            this.lblFertName.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFertName.Location = new System.Drawing.Point(21, 25);
            this.lblFertName.Name = "lblFertName";
            this.lblFertName.Size = new System.Drawing.Size(69, 18);
            this.lblFertName.TabIndex = 0;
            this.lblFertName.Text = "Fertilizer:";
            // 
            // tabHarvest
            // 
            this.tabHarvest.BackgroundImage = global::AgroDoc.Properties.Resources._3203324;
            this.tabHarvest.Controls.Add(this.dgvHarvestStock);
            this.tabHarvest.Controls.Add(this.grpHarvestOps);
            this.tabHarvest.Location = new System.Drawing.Point(4, 25);
            this.tabHarvest.Name = "tabHarvest";
            this.tabHarvest.Padding = new System.Windows.Forms.Padding(3);
            this.tabHarvest.Size = new System.Drawing.Size(823, 509);
            this.tabHarvest.TabIndex = 1;
            this.tabHarvest.Text = "Harvest Log";
            this.tabHarvest.UseVisualStyleBackColor = true;
            // 
            // dgvHarvestStock
            // 
            this.dgvHarvestStock.AllowUserToAddRows = false;
            this.dgvHarvestStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHarvestStock.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dgvHarvestStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHarvestStock.Location = new System.Drawing.Point(20, 164);
            this.dgvHarvestStock.Name = "dgvHarvestStock";
            this.dgvHarvestStock.ReadOnly = true;
            this.dgvHarvestStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHarvestStock.Size = new System.Drawing.Size(781, 339);
            this.dgvHarvestStock.TabIndex = 1;
            // 
            // grpHarvestOps
            // 
            this.grpHarvestOps.Controls.Add(this.rbSold);
            this.grpHarvestOps.Controls.Add(this.rbHarvested);
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
            this.grpHarvestOps.Size = new System.Drawing.Size(781, 138);
            this.grpHarvestOps.TabIndex = 0;
            this.grpHarvestOps.TabStop = false;
            this.grpHarvestOps.Text = "Log New Harvest Entry";
            // 
            // btnSaveHarvest
            // 
            this.btnSaveHarvest.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveHarvest.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveHarvest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveHarvest.Location = new System.Drawing.Point(684, 49);
            this.btnSaveHarvest.Name = "btnSaveHarvest";
            this.btnSaveHarvest.Size = new System.Drawing.Size(83, 46);
            this.btnSaveHarvest.TabIndex = 10;
            this.btnSaveHarvest.Text = "Record Harvest";
            this.btnSaveHarvest.UseVisualStyleBackColor = false;
            this.btnSaveHarvest.Click += new System.EventHandler(this.btnSaveHarvest_Click_1);
            // 
            // txtHarvestNotes
            // 
            this.txtHarvestNotes.Location = new System.Drawing.Point(515, 27);
            this.txtHarvestNotes.Name = "txtHarvestNotes";
            this.txtHarvestNotes.Size = new System.Drawing.Size(159, 105);
            this.txtHarvestNotes.TabIndex = 9;
            this.txtHarvestNotes.Text = "Good moisture condition";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(512, 8);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(105, 16);
            this.lblNotes.TabIndex = 8;
            this.lblNotes.Text = "Notes / Quality:";
            // 
            // txtStorageLocation
            // 
            this.txtStorageLocation.Location = new System.Drawing.Point(196, 106);
            this.txtStorageLocation.Name = "txtStorageLocation";
            this.txtStorageLocation.Size = new System.Drawing.Size(130, 22);
            this.txtStorageLocation.TabIndex = 7;
            this.txtStorageLocation.Text = "Main Werehouse";
            // 
            // lblStorageLoc
            // 
            this.lblStorageLoc.AutoSize = true;
            this.lblStorageLoc.Location = new System.Drawing.Point(194, 83);
            this.lblStorageLoc.Name = "lblStorageLoc";
            this.lblStorageLoc.Size = new System.Drawing.Size(116, 16);
            this.lblStorageLoc.TabIndex = 6;
            this.lblStorageLoc.Text = "Storage Location:";
            // 
            // dtpHarvestDate
            // 
            this.dtpHarvestDate.Location = new System.Drawing.Point(344, 53);
            this.dtpHarvestDate.Name = "dtpHarvestDate";
            this.dtpHarvestDate.Size = new System.Drawing.Size(147, 22);
            this.dtpHarvestDate.TabIndex = 5;
            // 
            // lblHarvestDate
            // 
            this.lblHarvestDate.AutoSize = true;
            this.lblHarvestDate.Location = new System.Drawing.Point(341, 26);
            this.lblHarvestDate.Name = "lblHarvestDate";
            this.lblHarvestDate.Size = new System.Drawing.Size(106, 16);
            this.lblHarvestDate.TabIndex = 4;
            this.lblHarvestDate.Text = "Date Harvested:";
            // 
            // txtHarvestQuantity
            // 
            this.txtHarvestQuantity.Location = new System.Drawing.Point(197, 54);
            this.txtHarvestQuantity.Name = "txtHarvestQuantity";
            this.txtHarvestQuantity.Size = new System.Drawing.Size(96, 22);
            this.txtHarvestQuantity.TabIndex = 3;
            this.txtHarvestQuantity.Text = "0";
            // 
            // lblHarvestQty
            // 
            this.lblHarvestQty.AutoSize = true;
            this.lblHarvestQty.Location = new System.Drawing.Point(194, 28);
            this.lblHarvestQty.Name = "lblHarvestQty";
            this.lblHarvestQty.Size = new System.Drawing.Size(132, 16);
            this.lblHarvestQty.TabIndex = 2;
            this.lblHarvestQty.Text = "Yield Quantity (KG):";
            // 
            // cmbHarvestCrop
            // 
            this.cmbHarvestCrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHarvestCrop.FormattingEnabled = true;
            this.cmbHarvestCrop.Location = new System.Drawing.Point(19, 53);
            this.cmbHarvestCrop.Name = "cmbHarvestCrop";
            this.cmbHarvestCrop.Size = new System.Drawing.Size(157, 24);
            this.cmbHarvestCrop.TabIndex = 1;
            // 
            // lblCropName
            // 
            this.lblCropName.AutoSize = true;
            this.lblCropName.Location = new System.Drawing.Point(16, 26);
            this.lblCropName.Name = "lblCropName";
            this.lblCropName.Size = new System.Drawing.Size(108, 16);
            this.lblCropName.TabIndex = 0;
            this.lblCropName.Text = "Harvested Crop:";
            // 
            // rbHarvested
            // 
            this.rbHarvested.AutoSize = true;
            this.rbHarvested.Location = new System.Drawing.Point(19, 83);
            this.rbHarvested.Name = "rbHarvested";
            this.rbHarvested.Size = new System.Drawing.Size(89, 20);
            this.rbHarvested.TabIndex = 11;
            this.rbHarvested.TabStop = true;
            this.rbHarvested.Text = "Harvested";
            this.rbHarvested.UseVisualStyleBackColor = true;
            // 
            // rbSold
            // 
            this.rbSold.AutoSize = true;
            this.rbSold.Location = new System.Drawing.Point(19, 109);
            this.rbSold.Name = "rbSold";
            this.rbSold.Size = new System.Drawing.Size(52, 20);
            this.rbSold.TabIndex = 12;
            this.rbSold.TabStop = true;
            this.rbSold.Text = "Sold";
            this.rbSold.UseVisualStyleBackColor = true;
            // 
            // FormStorageTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::AgroDoc.Properties.Resources._3203324;
            this.ClientSize = new System.Drawing.Size(846, 592);
            this.Controls.Add(this.btnGoToDelete);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.RadioButton rbSold;
        private System.Windows.Forms.RadioButton rbHarvested;
    }
}