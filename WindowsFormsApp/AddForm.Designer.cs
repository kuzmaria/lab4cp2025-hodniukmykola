namespace WindowsFormsApp
{
    partial class AddForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblProcessorType;
        private System.Windows.Forms.TextBox txtProcessorType;

        private System.Windows.Forms.Label lblProcessorBrand;
        private System.Windows.Forms.TextBox txtProcessorBrand;

        private System.Windows.Forms.Label lblProcessorFreq;
        private System.Windows.Forms.TextBox txtProcessorFreq;

        private System.Windows.Forms.Label lblMonitorType;
        private System.Windows.Forms.TextBox txtMonitorType;

        private System.Windows.Forms.Label lblMonitorBrand;
        private System.Windows.Forms.TextBox txtMonitorBrand;

        private System.Windows.Forms.Label lblMonitorFreq;
        private System.Windows.Forms.TextBox txtMonitorFreq;

        private System.Windows.Forms.Label lblHDDType;
        private System.Windows.Forms.TextBox txtHDDType;

        private System.Windows.Forms.Label lblHDDBrand;
        private System.Windows.Forms.TextBox txtHDDBrand;

        private System.Windows.Forms.Label lblHDDCap;
        private System.Windows.Forms.TextBox txtHDDCap;

        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblProcessorType = new System.Windows.Forms.Label();
            this.txtProcessorType = new System.Windows.Forms.TextBox();
            this.lblProcessorBrand = new System.Windows.Forms.Label();
            this.txtProcessorBrand = new System.Windows.Forms.TextBox();
            this.lblProcessorFreq = new System.Windows.Forms.Label();
            this.txtProcessorFreq = new System.Windows.Forms.TextBox();
            this.lblMonitorType = new System.Windows.Forms.Label();
            this.txtMonitorType = new System.Windows.Forms.TextBox();
            this.lblMonitorBrand = new System.Windows.Forms.Label();
            this.txtMonitorBrand = new System.Windows.Forms.TextBox();
            this.lblMonitorFreq = new System.Windows.Forms.Label();
            this.txtMonitorFreq = new System.Windows.Forms.TextBox();
            this.lblHDDType = new System.Windows.Forms.Label();
            this.txtHDDType = new System.Windows.Forms.TextBox();
            this.lblHDDBrand = new System.Windows.Forms.Label();
            this.txtHDDBrand = new System.Windows.Forms.TextBox();
            this.lblHDDCap = new System.Windows.Forms.Label();
            this.txtHDDCap = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProcessorType
            // 
            this.lblProcessorType.AutoSize = true;
            this.lblProcessorType.Location = new System.Drawing.Point(12, 12);
            this.lblProcessorType.Name = "lblProcessorType";
            this.lblProcessorType.Size = new System.Drawing.Size(109, 16);
            this.lblProcessorType.TabIndex = 0;
            this.lblProcessorType.Text = "Тип процесора:";
            // 
            // txtProcessorType
            // 
            this.txtProcessorType.Location = new System.Drawing.Point(12, 30);
            this.txtProcessorType.Name = "txtProcessorType";
            this.txtProcessorType.Size = new System.Drawing.Size(260, 22);
            this.txtProcessorType.TabIndex = 1;
            // 
            // lblProcessorBrand
            // 
            this.lblProcessorBrand.AutoSize = true;
            this.lblProcessorBrand.Location = new System.Drawing.Point(12, 60);
            this.lblProcessorBrand.Name = "lblProcessorBrand";
            this.lblProcessorBrand.Size = new System.Drawing.Size(148, 16);
            this.lblProcessorBrand.TabIndex = 2;
            this.lblProcessorBrand.Text = "Виробник процесора:";
            // 
            // txtProcessorBrand
            // 
            this.txtProcessorBrand.Location = new System.Drawing.Point(12, 78);
            this.txtProcessorBrand.Name = "txtProcessorBrand";
            this.txtProcessorBrand.Size = new System.Drawing.Size(260, 22);
            this.txtProcessorBrand.TabIndex = 3;
            // 
            // lblProcessorFreq
            // 
            this.lblProcessorFreq.AutoSize = true;
            this.lblProcessorFreq.Location = new System.Drawing.Point(12, 108);
            this.lblProcessorFreq.Name = "lblProcessorFreq";
            this.lblProcessorFreq.Size = new System.Drawing.Size(171, 16);
            this.lblProcessorFreq.TabIndex = 4;
            this.lblProcessorFreq.Text = "Частота процесора (ГГц):";
            // 
            // txtProcessorFreq
            // 
            this.txtProcessorFreq.Location = new System.Drawing.Point(12, 126);
            this.txtProcessorFreq.Name = "txtProcessorFreq";
            this.txtProcessorFreq.Size = new System.Drawing.Size(260, 22);
            this.txtProcessorFreq.TabIndex = 5;
            // 
            // lblMonitorType
            // 
            this.lblMonitorType.AutoSize = true;
            this.lblMonitorType.Location = new System.Drawing.Point(12, 156);
            this.lblMonitorType.Name = "lblMonitorType";
            this.lblMonitorType.Size = new System.Drawing.Size(97, 16);
            this.lblMonitorType.TabIndex = 6;
            this.lblMonitorType.Text = "Тип монітора:";
            // 
            // txtMonitorType
            // 
            this.txtMonitorType.Location = new System.Drawing.Point(12, 174);
            this.txtMonitorType.Name = "txtMonitorType";
            this.txtMonitorType.Size = new System.Drawing.Size(260, 22);
            this.txtMonitorType.TabIndex = 7;
            // 
            // lblMonitorBrand
            // 
            this.lblMonitorBrand.AutoSize = true;
            this.lblMonitorBrand.Location = new System.Drawing.Point(12, 204);
            this.lblMonitorBrand.Name = "lblMonitorBrand";
            this.lblMonitorBrand.Size = new System.Drawing.Size(136, 16);
            this.lblMonitorBrand.TabIndex = 8;
            this.lblMonitorBrand.Text = "Виробник монітора:";
            // 
            // txtMonitorBrand
            // 
            this.txtMonitorBrand.Location = new System.Drawing.Point(12, 222);
            this.txtMonitorBrand.Name = "txtMonitorBrand";
            this.txtMonitorBrand.Size = new System.Drawing.Size(260, 22);
            this.txtMonitorBrand.TabIndex = 9;
            // 
            // lblMonitorFreq
            // 
            this.lblMonitorFreq.AutoSize = true;
            this.lblMonitorFreq.Location = new System.Drawing.Point(12, 252);
            this.lblMonitorFreq.Name = "lblMonitorFreq";
            this.lblMonitorFreq.Size = new System.Drawing.Size(152, 16);
            this.lblMonitorFreq.TabIndex = 10;
            this.lblMonitorFreq.Text = "Частота монітора (Гц):";
            // 
            // txtMonitorFreq
            // 
            this.txtMonitorFreq.Location = new System.Drawing.Point(12, 270);
            this.txtMonitorFreq.Name = "txtMonitorFreq";
            this.txtMonitorFreq.Size = new System.Drawing.Size(260, 22);
            this.txtMonitorFreq.TabIndex = 11;
            // 
            // lblHDDType
            // 
            this.lblHDDType.AutoSize = true;
            this.lblHDDType.Location = new System.Drawing.Point(12, 300);
            this.lblHDDType.Name = "lblHDDType";
            this.lblHDDType.Size = new System.Drawing.Size(111, 16);
            this.lblHDDType.TabIndex = 12;
            this.lblHDDType.Text = "Тип вінчестера:";
            // 
            // txtHDDType
            // 
            this.txtHDDType.Location = new System.Drawing.Point(12, 318);
            this.txtHDDType.Name = "txtHDDType";
            this.txtHDDType.Size = new System.Drawing.Size(260, 22);
            this.txtHDDType.TabIndex = 13;
            // 
            // lblHDDBrand
            // 
            this.lblHDDBrand.AutoSize = true;
            this.lblHDDBrand.Location = new System.Drawing.Point(12, 348);
            this.lblHDDBrand.Name = "lblHDDBrand";
            this.lblHDDBrand.Size = new System.Drawing.Size(150, 16);
            this.lblHDDBrand.TabIndex = 14;
            this.lblHDDBrand.Text = "Виробник вінчестера:";
            // 
            // txtHDDBrand
            // 
            this.txtHDDBrand.Location = new System.Drawing.Point(12, 366);
            this.txtHDDBrand.Name = "txtHDDBrand";
            this.txtHDDBrand.Size = new System.Drawing.Size(260, 22);
            this.txtHDDBrand.TabIndex = 15;
            // 
            // lblHDDCap
            // 
            this.lblHDDCap.AutoSize = true;
            this.lblHDDCap.Location = new System.Drawing.Point(12, 396);
            this.lblHDDCap.Name = "lblHDDCap";
            this.lblHDDCap.Size = new System.Drawing.Size(151, 16);
            this.lblHDDCap.TabIndex = 16;
            this.lblHDDCap.Text = "Обʼєм вінчестера (ГБ):";
            // 
            // txtHDDCap
            // 
            this.txtHDDCap.Location = new System.Drawing.Point(12, 414);
            this.txtHDDCap.Name = "txtHDDCap";
            this.txtHDDCap.Size = new System.Drawing.Size(260, 22);
            this.txtHDDCap.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 30);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddForm
            // 
            this.ClientSize = new System.Drawing.Size(305, 490);
            this.Controls.Add(this.lblProcessorType);
            this.Controls.Add(this.txtProcessorType);
            this.Controls.Add(this.lblProcessorBrand);
            this.Controls.Add(this.txtProcessorBrand);
            this.Controls.Add(this.lblProcessorFreq);
            this.Controls.Add(this.txtProcessorFreq);
            this.Controls.Add(this.lblMonitorType);
            this.Controls.Add(this.txtMonitorType);
            this.Controls.Add(this.lblMonitorBrand);
            this.Controls.Add(this.txtMonitorBrand);
            this.Controls.Add(this.lblMonitorFreq);
            this.Controls.Add(this.txtMonitorFreq);
            this.Controls.Add(this.lblHDDType);
            this.Controls.Add(this.txtHDDType);
            this.Controls.Add(this.lblHDDBrand);
            this.Controls.Add(this.txtHDDBrand);
            this.Controls.Add(this.lblHDDCap);
            this.Controls.Add(this.txtHDDCap);
            this.Controls.Add(this.btnSave);
            this.Name = "AddForm";
            this.Text = "Додати аксесуар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
