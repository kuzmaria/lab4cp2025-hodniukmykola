using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class OrderForm : Form
    {
        public int SelectedAccessoryId { get; private set; } = -1;
        public int Quantity { get; private set; } = 0;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAccessoryId.Text, out int id) && int.TryParse(txtQuantity.Text, out int qty))
            {
                if (qty <= 0)
                {
                    MessageBox.Show("Кількість має бути більшою за 0");
                    return;
                }
                SelectedAccessoryId = id;
                Quantity = qty;
                MessageBox.Show($"Замовлення створено:\nАксесуар ID: {id}\nКількість: {qty}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Введіть коректні числові значення для ID та кількості");
            }
        }
    }
}
