using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp
{
    public partial class EditForm : Form
    {
        private int accessoryId;
        string connStr = "Server=localhost;Port=3306;Database=accessories_db;Uid=root;Pwd=newpassword;;";

        public EditForm(int id)
        {
            InitializeComponent();
            accessoryId = id;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            LoadAccessoryData();
        }

        private void LoadAccessoryData()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM accessories WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", accessoryId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtProcessorType.Text = reader["processor_type"].ToString();
                            txtProcessorBrand.Text = reader["processor_brand"].ToString();
                            txtProcessorFreq.Text = reader["processor_frequency"].ToString();

                            txtMonitorType.Text = reader["monitor_type"].ToString();
                            txtMonitorBrand.Text = reader["monitor_brand"].ToString();
                            txtMonitorFreq.Text = reader["monitor_frequency"].ToString();

                            txtHDDType.Text = reader["hdd_type"].ToString();
                            txtHDDBrand.Text = reader["hdd_brand"].ToString();
                            txtHDDCap.Text = reader["hdd_capacity"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні даних: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE accessories SET 
                                        processor_type = @processor_type,
                                        processor_brand = @processor_brand,
                                        processor_frequency = @processor_frequency,
                                        monitor_type = @monitor_type,
                                        monitor_brand = @monitor_brand,
                                        monitor_frequency = @monitor_frequency,
                                        hdd_type = @hdd_type,
                                        hdd_brand = @hdd_brand,
                                        hdd_capacity = @hdd_capacity
                                     WHERE id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@processor_type", txtProcessorType.Text);
                    cmd.Parameters.AddWithValue("@processor_brand", txtProcessorBrand.Text);
                    cmd.Parameters.AddWithValue("@processor_frequency", Convert.ToDecimal(txtProcessorFreq.Text));

                    cmd.Parameters.AddWithValue("@monitor_type", txtMonitorType.Text);
                    cmd.Parameters.AddWithValue("@monitor_brand", txtMonitorBrand.Text);
                    cmd.Parameters.AddWithValue("@monitor_frequency", Convert.ToInt32(txtMonitorFreq.Text));

                    cmd.Parameters.AddWithValue("@hdd_type", txtHDDType.Text);
                    cmd.Parameters.AddWithValue("@hdd_brand", txtHDDBrand.Text);
                    cmd.Parameters.AddWithValue("@hdd_capacity", Convert.ToInt32(txtHDDCap.Text));

                    cmd.Parameters.AddWithValue("@id", accessoryId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Дані успішно оновлено!");
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
