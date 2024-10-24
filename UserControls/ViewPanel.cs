using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrototypeRent.UserControls
{
    public partial class ViewPanel : UserControl
    {
        public ViewPanel()
        {
            InitializeComponent();
        }

        // Event handler for the form's Load event
        private void ViewPanel_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        // Method to load data from the database into the DataGridView
        private void LoadDataIntoDataGridView()
        {
            string connectionString = "Data Source=SYLZAE;Initial Catalog=ContractDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();

                string query = "SELECT * FROM ContractsTable WHERE IsTerminated = 0 ";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
