using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp
{
    public partial class SearchForm : Form
    {
        string connStr = "Server=localhost;Port=3306;Database=accessories_db;Uid=root;Pwd=newpassword;;";

        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string searchTerm = txtSearch.Text.Trim();

                    string query = @"SELECT * FROM accessories 
                                     WHERE processor_type LIKE @term OR processor_brand LIKE @term 
                                     OR monitor_type LIKE @term OR monitor_brand LIKE @term
                                     OR hdd_type LIKE @term OR hdd_brand LIKE @term";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@term", "%" + searchTerm + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewResults.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка пошуку: " + ex.Message);
                }
            }
        }
    }
}
