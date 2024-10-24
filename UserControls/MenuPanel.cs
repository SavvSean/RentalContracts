using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeRent.UserControls
{
    public partial class MenuPanel : UserControl
    {
        public MenuPanel()
        {
            InitializeComponent();
        }
        private void MenuPanel_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            HouseRules.Visible = !HouseRules.Visible;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
             dataGridView1.Visible = !dataGridView1.Visible;
        }

        private void LoadDataIntoDataGridView()
        {
            string connectionString = "Data Source=SYLZAE;Initial Catalog=ContractDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();

                string query = "SELECT * FROM ContractsTable WHERE IsTerminated = 1 ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt); 

                // Ensure DataGridView is set to auto-generate columns
                dataGridView1.AutoGenerateColumns = true;

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display any errors encountered
            }
            finally
            {
                con.Close(); // Ensure the connection is closed after use
            }
        }

        
    }
}
