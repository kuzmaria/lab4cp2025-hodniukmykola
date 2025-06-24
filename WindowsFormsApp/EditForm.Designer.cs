namespace WindowsFormsApp
{
    partial class EditForm
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

            // Label + TextBox positions аналогічні AddForm (можна скопіювати)

            // lblProcessorType
            this.lblProcessorType.AutoSize = true;
            this.lblProcessorType.Location = new System.Drawing.Point(12, 12);
            this.lblProcessorType.Text = "Тип процесора:";
            // txtProcessorType
            this.txtProcessorType.Location = new System.Drawing.Point(12, 30);
            this.txtProcessorType.Size = new System.Drawing.Size(260, 23);

            // lblProcessorBrand
            this.lblProcessorBrand.AutoSize = true;
            this.lblProcessorBrand.Location = new System.Drawing.Point(12, 60);
            this.lblProcessorBrand.Text = "Виробник процесора:";
            // txtProcessorBrand
            this.txtProcessorBrand.Location = new System.Drawing.Point(12, 78);
            this.txtProcessorBrand.Size = new System.Drawing.Size(260, 23);

            // lblProcessorFreq
            this.lblProcessorFreq.AutoSize = true;
            this.lblProcessorFreq.Location = new System.Drawing.Point(12, 108);
            this.lblProcessorFreq.Text = "Частота процесора (ГГц):";
            // txtProcessorFreq
            this.txtProcessorFreq.Location = new System.Drawing.Point(12, 126);
            this.txtProcessorFreq.Size = new System.Drawing.Size(260, 23);

            // lblMonitorType
            this.lblMonitorType.AutoSize = true;
            this.lblMonitorType.Location = new System.Drawing.Point(12, 156);
            this.lblMonitorType.Text = "Тип монітора:";
            // txtMonitorType
            this.txtMonitorType.Location = new System.Drawing.Point(12, 174);
            this.txtMonitorType.Size = new System.Drawing.Size(260, 23);

            // lblMonitorBrand
            this.lblMonitorBrand.AutoSize = true;
            this.lblMonitorBrand.Location = new System.Drawing.Point(12, 204);
            this.lblMonitorBrand.Text = "Виробник монітора:";
            // txtMonitorBrand
            this.txtMonitorBrand.Location = new System.Drawing.Point(12, 222);
            this.txtMonitorBrand.Size = new System.Drawing.Size(260, 23);

            // lblMonitorFreq
            this.lblMonitorFreq.AutoSize = true;
            this.lblMonitorFreq.Location = new System.Drawing.Point(12, 252);
            this.lblMonitorFreq.Text = "Частота монітора (Гц):";
            // txtMonitorFreq
            this.txtMonitorFreq.Location = new System.Drawing.Point(12, 270);
            this.txtMonitorFreq.Size = new System.Drawing.Size(260, 23);

            // lblHDDType
            this.lblHDDType.AutoSize = true;
            this.lblHDDType.Location = new System.Drawing.Point(12, 300);
            this.lblHDDType.Text = "Тип вінчестера:";
            // txtHDDType
            this.txtHDDType.Location = new System.Drawing.Point(12, 318);
            this.txtHDDType.Size = new System.Drawing.Size(260, 23);

            // lblHDDBrand
            this.lblHDDBrand.AutoSize = true;
            this.lblHDDBrand.Location = new System.Drawing.Point(12, 348);
            this.lblHDDBrand.Text = "Виробник вінчестера:";
            // txtHDDBrand
            this.txtHDDBrand.Location = new System.Drawing.Point(12, 366);
            this.txtHDDBrand.Size = new System.Drawing.Size(260, 23);

            // lblHDDCap
            this.lblHDDCap.AutoSize = true;
            this.lblHDDCap.Location = new System.Drawing.Point(12, 396);
            this.lblHDDCap.Text = "Обʼєм вінчестера (ГБ):";
            // txtHDDCap
            this.txtHDDCap.Location = new System.Drawing.Point(12, 414);
            this.txtHDDCap.Size = new System.Drawing.Size(260, 23);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(12, 450);
            this.btnSave.Size = new System.Drawing.Size(260, 30);
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Add controls
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

            this.ClientSize = new System.Drawing.Size(284, 490);
            this.Name = "EditForm";
            this.Text = "Редагувати аксесуар";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
