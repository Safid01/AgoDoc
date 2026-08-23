namespace AgroDoc
{
    partial class FormFertilizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFertilizer));
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.btnLoadLatest = new System.Windows.Forms.Button();
            this.lblCrop = new System.Windows.Forms.Label();
            this.cmbTargetCrop = new System.Windows.Forms.ComboBox();
            this.lblN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.lblP = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.lblK = new System.Windows.Forms.Label();
            this.txtPh = new System.Windows.Forms.TextBox();
            this.lblPh = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblDeficitHeader = new System.Windows.Forms.Label();
            this.txtDeficitSummary = new System.Windows.Forms.TextBox();
            this.lblGridHeader = new System.Windows.Forms.Label();
            this.dgvFertilizers = new System.Windows.Forms.DataGridView();
            this.grpInputs.SuspendLayout();
            this.grpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFertilizers)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.btnClear);
            this.grpInputs.Controls.Add(this.btnCalculate);
            this.grpInputs.Controls.Add(this.txtPh);
            this.grpInputs.Controls.Add(this.lblPh);
            this.grpInputs.Controls.Add(this.txtK);
            this.grpInputs.Controls.Add(this.lblK);
            this.grpInputs.Controls.Add(this.txtP);
            this.grpInputs.Controls.Add(this.lblP);
            this.grpInputs.Controls.Add(this.txtN);
            this.grpInputs.Controls.Add(this.lblN);
            this.grpInputs.Controls.Add(this.cmbTargetCrop);
            this.grpInputs.Controls.Add(this.lblCrop);
            this.grpInputs.Controls.Add(this.btnLoadLatest);
            resources.ApplyResources(this.grpInputs, "grpInputs");
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.TabStop = false;
            // 
            // btnLoadLatest
            // 
            resources.ApplyResources(this.btnLoadLatest, "btnLoadLatest");
            this.btnLoadLatest.Name = "btnLoadLatest";
            this.btnLoadLatest.UseVisualStyleBackColor = true;
            this.btnLoadLatest.Click += new System.EventHandler(this.btnLoadLatest_Click);
            // 
            // lblCrop
            // 
            resources.ApplyResources(this.lblCrop, "lblCrop");
            this.lblCrop.Name = "lblCrop";
            // 
            // cmbTargetCrop
            // 
            this.cmbTargetCrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetCrop.FormattingEnabled = true;
            resources.ApplyResources(this.cmbTargetCrop, "cmbTargetCrop");
            this.cmbTargetCrop.Name = "cmbTargetCrop";
            // 
            // lblN
            // 
            resources.ApplyResources(this.lblN, "lblN");
            this.lblN.Name = "lblN";
            // 
            // txtN
            // 
            resources.ApplyResources(this.txtN, "txtN");
            this.txtN.Name = "txtN";
            // 
            // txtP
            // 
            resources.ApplyResources(this.txtP, "txtP");
            this.txtP.Name = "txtP";
            // 
            // lblP
            // 
            resources.ApplyResources(this.lblP, "lblP");
            this.lblP.Name = "lblP";
            // 
            // txtK
            // 
            resources.ApplyResources(this.txtK, "txtK");
            this.txtK.Name = "txtK";
            // 
            // lblK
            // 
            resources.ApplyResources(this.lblK, "lblK");
            this.lblK.Name = "lblK";
            // 
            // txtPh
            // 
            resources.ApplyResources(this.txtPh, "txtPh");
            this.txtPh.Name = "txtPh";
            // 
            // lblPh
            // 
            resources.ApplyResources(this.lblPh, "lblPh");
            this.lblPh.Name = "lblPh";
            // 
            // btnCalculate
            // 
            resources.ApplyResources(this.btnCalculate, "btnCalculate");
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.dgvFertilizers);
            this.grpResults.Controls.Add(this.lblGridHeader);
            this.grpResults.Controls.Add(this.txtDeficitSummary);
            this.grpResults.Controls.Add(this.lblDeficitHeader);
            resources.ApplyResources(this.grpResults, "grpResults");
            this.grpResults.Name = "grpResults";
            this.grpResults.TabStop = false;
            // 
            // lblDeficitHeader
            // 
            resources.ApplyResources(this.lblDeficitHeader, "lblDeficitHeader");
            this.lblDeficitHeader.Name = "lblDeficitHeader";
            // 
            // txtDeficitSummary
            // 
            resources.ApplyResources(this.txtDeficitSummary, "txtDeficitSummary");
            this.txtDeficitSummary.Name = "txtDeficitSummary";
            // 
            // lblGridHeader
            // 
            resources.ApplyResources(this.lblGridHeader, "lblGridHeader");
            this.lblGridHeader.Name = "lblGridHeader";
            // 
            // dgvFertilizers
            // 
            this.dgvFertilizers.AllowUserToAddRows = false;
            this.dgvFertilizers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFertilizers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvFertilizers, "dgvFertilizers");
            this.dgvFertilizers.Name = "dgvFertilizers";
            this.dgvFertilizers.ReadOnly = true;
            this.dgvFertilizers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // FormFertilizer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpInputs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFertilizer";
            this.Load += new System.EventHandler(this.FormFertilizer_Load);
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFertilizers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Button btnLoadLatest;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.ComboBox cmbTargetCrop;
        private System.Windows.Forms.Label lblCrop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtPh;
        private System.Windows.Forms.Label lblPh;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.DataGridView dgvFertilizers;
        private System.Windows.Forms.Label lblGridHeader;
        private System.Windows.Forms.TextBox txtDeficitSummary;
        private System.Windows.Forms.Label lblDeficitHeader;
    }
}