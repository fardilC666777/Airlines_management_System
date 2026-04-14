using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Airline_Management_System
{
    public partial class ViewPassenger : Form
    {
        public ViewPassenger()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from PassengerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ViewPassBack_btn_Click(object sender, EventArgs e)
        {
            AddPassenger addb = new AddPassenger();
            addb.Show();
            this.Hide();
        }

        private void ViewDelete_btn_Click(object sender, EventArgs e)
        {
            if (PidTb.Text == "")
            {
                MessageBox.Show("Enter the Passenger to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PassengerTbl where PassId=" + PidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PassengerDGV.Rows[e.RowIndex];
                PidTb.Text = row.Cells[0].Value.ToString();
                PnameTb.Text = row.Cells[1].Value.ToString();
                PpassTb.Text = row.Cells[2].Value.ToString();
                PaddTb.Text = row.Cells[3].Value.ToString();
                natcb.SelectedItem = row.Cells[4].Value.ToString();
                GendCb.SelectedItem = row.Cells[5].Value.ToString();
                PphoneTb.Text = row.Cells[6].Value.ToString();
            }
        }

        private void ViewPassRes_btn_Click(object sender, EventArgs e)
        {
            PidTb.Text = "";
            PnameTb.Text = "";
            PpassTb.Text = "";
            PaddTb.Text = "";
            natcb.SelectedItem = -1;
            GendCb.SelectedItem = -1;
            PphoneTb.Text = "";
        }

        private void ViewPassUpdt_btn_Click(object sender, EventArgs e)
        {
            if (PidTb.Text == "" || PnameTb.Text == "" || PpassTb.Text == "" || PaddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PassengerTbl set PassName='" + PnameTb.Text + "', Passport='" + PpassTb.Text + "', Passad='" + PaddTb.Text + "', PassNat='" + natcb.SelectedItem.ToString() + "', PassGend='" + GendCb.SelectedItem.ToString() + "', PassPhone='" + PphoneTb.Text + "' where PassId=" + PidTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void V_flight_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

