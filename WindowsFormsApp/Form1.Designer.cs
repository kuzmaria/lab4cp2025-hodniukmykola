namespace WindowsFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnLogin;

        /// <summary>
        /// Очистка ресурсів
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Ініціалізація компонентів форми
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                            | System.Windows.Forms.AnchorStyles.Left)
                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;  // Таблиця тільки для читання
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 420);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Оновити";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(230, 420);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(340, 420);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(100, 30);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Замовлення";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
           
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Облік аксесуарів";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
 