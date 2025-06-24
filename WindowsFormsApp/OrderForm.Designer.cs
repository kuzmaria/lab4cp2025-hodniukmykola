namespace WindowsFormsApp
{
    partial class OrderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAccessoryId;
        private System.Windows.Forms.TextBox txtAccessoryId;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnOrder;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAccessoryId = new System.Windows.Forms.Label();
            this.txtAccessoryId = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccessoryId
            // 
            this.lblAccessoryId.AutoSize = true;
            this.lblAccessoryId.Location = new System.Drawing.Point(12, 15);
            this.lblAccessoryId.Name = "lblAccessoryId";
            this.lblAccessoryId.Size = new System.Drawing.Size(82, 15);
            this.lblAccessoryId.Text = "ID аксесуара:";
            // 
            // txtAccessoryId
            // 
            this.txtAccessoryId.Location = new System.Drawing.Point(120, 12);
            this.txtAccessoryId.Name = "txtAccessoryId";
            this.txtAccessoryId.Size = new System.Drawing.Size(140, 23);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 55);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.Text = "Кількість:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(120, 52);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(140, 23);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(12, 90);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(248, 30);
            this.btnOrder.Text = "Замовити";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // OrderForm
            // 
            this.ClientSize = new System.Drawing.Size(280, 140);
            this.Controls.Add(this.lblAccessoryId);
            this.Controls.Add(this.txtAccessoryId);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnOrder);
            this.Name = "OrderForm";
            this.Text = "Замовлення аксесуарів";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
