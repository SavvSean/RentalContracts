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
using System.Xml.Linq;

namespace PrototypeRent.UserControls
{
    public partial class CreatePanel : UserControl
    {
        public CreatePanel()
        {
            InitializeComponent();
        }

        private void CreatePanel_Load(object sender, EventArgs e)
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

                //string Query = "SELECT * FROM Name, Contact_Number, Email, Building_Number, Room_Number, Pending, InsertedDate FROM ContractsTable ORDER BY InsertedDate DESC";
                string Query = "SELECT TOP 1 * FROM ContractsTable ORDER BY InsertedDate DESC";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                dataGridView1.AutoGenerateColumns = true;


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

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            // Trim inputs to remove leading/trailing whitespace
            string Name = tbName.Text.Trim();
            string Contact_Number = tbContact.Text.Trim();
            string Email = tbEmail.Text.Trim();
            string Building_Number = tbBuilding.Text.Trim();
            string Room_Number = tbRoom.Text.Trim();
            string Pending = tbPending.Text.Trim();

            // Check if any required field is empty or contains only whitespace
            if (string.IsNullOrWhiteSpace(Name) ||
                string.IsNullOrWhiteSpace(Contact_Number) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Building_Number) ||
                string.IsNullOrWhiteSpace(Room_Number) ||
                string.IsNullOrWhiteSpace(Pending))
            {
                MessageBox.Show("Please fill in all required fields.");
                return; // Exit the function without inserting into the database
            }

            string ConnectionString = "Data Source=SYLZAE;Initial Catalog=ContractDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();

                string Query = "INSERT INTO ContractsTable (Name, Contact_Number, Email, Building_Number, Room_Number, Pending) " +
                               "VALUES (@Name, @Contact_Number, @Email, @Building_Number, @Room_Number, @Pending)";

                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Contact_Number", Contact_Number);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Building_Number", Building_Number);
                cmd.Parameters.AddWithValue("@Room_Number", Room_Number);
                cmd.Parameters.AddWithValue("@Pending", Pending);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Created successfully.");

                // Refresh the DataGridView
                LoadDataIntoDataGridView();
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




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = !monthCalendar1.Visible;
        }
    }
}
