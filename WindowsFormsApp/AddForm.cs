using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp
{
    public partial class AddForm : Form
    {
        string connStr = "Server=localhost;Port=3306;Database=accessories_db;Uid=root;Pwd=newpassword;";

        public AddForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO accessories " +
                        "(processor_type, processor_brand, processor_frequency, " +
                        "monitor_type, monitor_brand, monitor_frequency, " +
                        "hdd_type, hdd_brand, hdd_capacity) " +
                        "VALUES (@pType, @pBrand, @pFreq, @mType, @mBrand, @mFreq, @hType, @hBrand, @hCap)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@pType", txtProcessorType.Text);
                    cmd.Parameters.AddWithValue("@pBrand", txtProcessorBrand.Text);
                    cmd.Parameters.AddWithValue("@pFreq", Convert.ToDecimal(txtProcessorFreq.Text));

                    cmd.Parameters.AddWithValue("@mType", txtMonitorType.Text);
                    cmd.Parameters.AddWithValue("@mBrand", txtMonitorBrand.Text);
                    cmd.Parameters.AddWithValue("@mFreq", Convert.ToInt32(txtMonitorFreq.Text));

                    cmd.Parameters.AddWithValue("@hType", txtHDDType.Text);
                    cmd.Parameters.AddWithValue("@hBrand", txtHDDBrand.Text);
                    cmd.Parameters.AddWithValue("@hCap", Convert.ToInt32(txtHDDCap.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Успішно додано!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при збереженні: " + ex.Message);
                }
            }
        }
    }
}
