using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Airline_Management_System
{
    public partial class FlightTbl : Form
    {
        public FlightTbl()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;


        }

        private void Fl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       /* private void NewFlight_RecordBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void NewFlight_ResetBtn_Click(object sender, EventArgs e)
        {
           
        }*/

        private void NewFlightBack_btn_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Close();
        }

        private void NewFlightView_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void FlightTbl_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");
            Con.Open();

            SqlCommand sql = new SqlCommand("select * from FlightTBL", Con);
            DataTable dt = new DataTable();

            SqlDataReader sdr = sql.ExecuteReader();
            dt.Load(sdr);

            dataGridView1.DataSource = dt;
            Con.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void RecordFlight_btn_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");

            try
            {
                Con.Open();
                SqlCommand sq2 = new SqlCommand("insert into FlightTBL (fcode, fsrc, fdest, fdate, fcap) values(@Fcode, @Fsrc, @FDest, @FDate, @FCap)", Con);
                sq2.Parameters.AddWithValue("@Fcode", textBox1.Text);

                sq2.Parameters.AddWithValue("@Fsrc", comboBox2.SelectedItem != null ? comboBox2.SelectedItem.ToString() : "");
                sq2.Parameters.AddWithValue("@FDest", comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "");
                sq2.Parameters.AddWithValue("@FDate", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                sq2.Parameters.AddWithValue("@FCap", int.Parse(textBox3.Text));

                sq2.ExecuteNonQuery();
                MessageBox.Show("Flight Recorded Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }


        private void FlightRefresh_btn_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");
            Con.Open();

            SqlCommand sql = new SqlCommand("select * from FlightTBL", Con);
            SqlDataAdapter ds = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            ds.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void V_flight_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void FlightBack_btn_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Close();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                textBox1.Text = selectedRow.Cells["fcode"].Value.ToString();
                comboBox2.SelectedItem = selectedRow.Cells["fsrc"].Value.ToString();
                comboBox1.SelectedItem = selectedRow.Cells["fdest"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["fdate"].Value);
                textBox3.Text = selectedRow.Cells["fcap"].Value.ToString();
            }
        }

        private void Flight_Update_btn_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");

            try
            {
                Con.Open();

                if (dataGridView1.SelectedRows.Count > 0)
                {

                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    SqlCommand sq3 = new SqlCommand("UPDATE FlightTBL SET fsrc = @Fsrc, fdest = @FDest, fdate = @FDate, fcap = @FCap WHERE fcode = @Fcode", Con);
                    sq3.Parameters.AddWithValue("@Fcode", selectedRow.Cells["fcode"].Value.ToString());
                    sq3.Parameters.AddWithValue("@Fsrc", comboBox2.SelectedItem != null ? comboBox2.SelectedItem.ToString() : "");
                    sq3.Parameters.AddWithValue("@FDest", comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "");
                    sq3.Parameters.AddWithValue("@FDate", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    sq3.Parameters.AddWithValue("@FCap", int.Parse(textBox3.Text));

                    sq3.ExecuteNonQuery();
                    MessageBox.Show("Flight Information Updated");
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void Flights_Delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");

            try
            {
                Con.Open();

                if (dataGridView1.SelectedRows.Count > 0)
                {
                   
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    SqlCommand sq4 = new SqlCommand("DELETE FROM FlightTBL WHERE fcode = @Fcode", Con);
                    sq4.Parameters.AddWithValue("@Fcode", selectedRow.Cells["fcode"].Value.ToString());

                    sq4.ExecuteNonQuery();
                    MessageBox.Show("Flight Information Deleted");
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void Flight_Reset_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox2.SelectedIndex = -1;  
            comboBox1.SelectedIndex = -1;  
            dateTimePicker1.Value = DateTime.Now;  
            textBox3.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
