using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Airline_Management_System
{
    public partial class Ticket : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private BindingSource bindingSource;
        public Ticket()
        {
            InitializeComponent();
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from TicketTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void fillPassenger()
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("select PassId from PassengerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassId", typeof(int));
            dt.Load(rdr);
            PIdCb.ValueMember = "PassId";
            PIdCb.DataSource = dt;

            Con.Close();
        }

        private void fillFlightCode()
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("select Fcode from FlightTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fcode", typeof(string));
            dt.Load(rdr);
            FCodeCb.ValueMember = "Fcode";
            FCodeCb.DataSource = dt;

            Con.Close();
        }

        private void fetchPassenger()
        {
            Con.Open();

            string query = "select * from PassengerTbl where PassId=" + PIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PNameTb.Text = dr["PassName"].ToString();
                PPassTb.Text = dr["Passport"].ToString();
                PNatTb.Text = dr["PassNat"].ToString();
            }

            Con.Close();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            fillPassenger();
            fillFlightCode();
            populate();

            bindingSource = new BindingSource();
            bindingSource.DataSource = (TicketDGV.DataSource as DataTable);
            TicketDGV.DataSource = bindingSource;
        }

        private void BookTicket_btn_Click(object sender, EventArgs e)
        {
            if (Tid.Text == "" || PNameTb.Text == "" || SnoTb.Text == "" || ClassTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                   
                    string query = "INSERT INTO TicketTbl VALUES(@Tid, @FCode, @PId, @PName, @PPass, @PNat, @PAmt, @Sno, @Class)";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@Tid", Tid.Text);
                    cmd.Parameters.AddWithValue("@FCode", FCodeCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PId", PIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PName", PNameTb.Text);
                    cmd.Parameters.AddWithValue("@PPass", PPassTb.Text);
                    cmd.Parameters.AddWithValue("@PNat", PNatTb.Text);
                    cmd.Parameters.AddWithValue("@PAmt", PAmtTb.Text);
                    cmd.Parameters.AddWithValue("@Sno", SnoTb.Text);
                    cmd.Parameters.AddWithValue("@Class", ClassTb.Text);

                    string checkQuery = "SELECT COUNT(*) FROM TicketTbl WHERE Sno = @Sno";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                    checkCmd.Parameters.AddWithValue("@Sno", SnoTb.Text);
                    int seatCount = (int)checkCmd.ExecuteScalar();

                    if (seatCount > 0)
                    {
                        MessageBox.Show("Seat Number Already Taken. Please Choose A Different Seat!!!");
                    }
                    else
                    {

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ticket Booked Successfully!!");
                        Con.Close();

                        populate();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void Ticket_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TicketBack_btn_Click(object sender, EventArgs e)
        {
           Login_Form lf = new Login_Form();
            lf.Show();
            this.Close();
        }

        private void ResetTicket_btn_Click(object sender, EventArgs e)
        {
            PNameTb.Text = "";
            PPassTb.Text = "";
            PNatTb.Text = "";
            PAmtTb.Text = "";
            Tid.Text = "";
            SnoTb.Text = "";
            ClassTb.Text = "";
        }

        private void PIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchPassenger();
        }

        private void TicketDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_ticketBtn_Click(object sender, EventArgs e)
        {
            string searchCriteria = Tid.Text.Trim();

            if (!string.IsNullOrEmpty(searchCriteria))
            {
                try
                {
                    bindingSource.Filter = "Convert(Tid, 'System.String') LIKE '%" + searchCriteria + "%'";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                
                bindingSource.RemoveFilter();
            }
            

        }
    }
}

