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
    public partial class RenewPanel : UserControl
    {
        public RenewPanel()
        {
            InitializeComponent();
        }

        private void RenewPanel_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();

        }

        private void LoadDataIntoDataGridView()
        {
            string ConnectionString = "Data Source=SYLZAE;Initial Catalog=ContractDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();

                string Query = "SELECT * FROM ContractsTable WHERE IsTerminated = 0 ORDER BY InsertedDate ASC";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                dataGridView1.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e) // "Paid" button
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns[6].Index)
            {
                // Update the status in the DataGridView
                dataGridView1.CurrentCell.Value = "Paid";

                // Get the ID of the selected row to update in the database
                int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

                // Update the status in the database
                UpdateStatus(id, "Paid");
            }
            else
            {
                MessageBox.Show("Please select a cell in the Status column.");
            }
        }

        private void button2_Click(object sender, EventArgs e) // "Unpaid" button
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns[6].Index)
            {
                // Update the status in the DataGridView
                dataGridView1.CurrentCell.Value = "Unpaid";

                // Get the ID of the selected row to update in the database
                int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

                // Update the status in the database
                UpdateStatus(id, "Unpaid");
            }
            else
            {
                MessageBox.Show("Please select a cell in the Status column.");
            }
        }

        private void UpdateStatus(int id, string status)
        {
            string updateQuery = "UPDATE ContractsTable SET Status = @status WHERE ID = @id";

            string ConnectionString = "Data Source=SYLZAE;Initial Catalog=ContractDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}