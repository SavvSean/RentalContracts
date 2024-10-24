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
    public partial class TerminatePanel : UserControl
    {
        public TerminatePanel()
        {
            InitializeComponent();
        }


         private void TerminatePanel_Load_1(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Ensure a row is selected
            {
                // Get the ID from the selected row
                int contractID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                // Terminate the selected contract
                TerminateContract(contractID);

                // Refresh the DataGridView to reflect the change
                LoadDataIntoDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a contract to terminate.");
            }
        }




        // Method to load data from the database into the DataGridView
        private void LoadDataIntoDataGridView()
        {
            string ConnectionString = "Data Source=SYLZAE;Initial Catalog=ContractDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();

                // Select active contracts (IsTerminated = 0) and include ID
                //string Query = "SELECT ID, Name, Contact_Number, Email, Building_Number, Room_Number, Pending, Status, InsertedDate " +
                //    "FROM ContractsTable WHERE IsTerminated = 0 ORDER BY InsertedDate ASC";
                string Query = "SELECT Name, Contact_Number, Email, Building_Number, Room_Number, Status " + "FROM ContractsTable WHERE IsTerminated = 0 ORDER BY InsertedDate ASC";
                //string Query = "SELECT * FROM ContractsTable";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.DataSource = dt; // Display the data in the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void TerminateContract(int contractId)
        {
            string query = "UPDATE ContractsTable SET IsTerminated = 1 WHERE ID = @ID";

            string ConnectionString = "Data Source=SYLZAE;Initial Catalog=ContractDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", contractId);
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Contract terminated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Termination failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }




        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
