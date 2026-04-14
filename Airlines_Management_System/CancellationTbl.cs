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
using System.Security.Cryptography;

namespace Airline_Management_System
{
    public partial class CancellationTbl : Form
    {
        public CancellationTbl()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void fillTickeetId()
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("select Tid from TicketTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tid", typeof(string));
            dt.Load(rdr);
            TidCb.ValueMember = "Tid";
            TidCb.DataSource = dt;

            Con.Close();
        }
        private void CancellationTbl_Load(object sender, EventArgs e)
        {
            fillTickeetId();
            populate();
        }

        private void fetchfcode()
        {
            Con.Open();

            string query = "select * from TicketTbl where Tid=" + TidCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FcodeTb.Text = dr["Fcode"].ToString();

            }

            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CancelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CancelDGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void TidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchfcode();
        }
        private void deleteTicket()
        {
            try
            {
                Con.Open();
                string query = "delete from TicketTbl where Tid= " + TidCb.SelectedValue.ToString() + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ticket Deleted Successfully");
                Con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancTicket_btn_Click(object sender, EventArgs e)
        {
            if (CanId.Text == "" || FcodeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();


                    string query = "INSERT INTO CancelTbl VALUES(@CancId, @TicId, @Flcode, @CancDate)";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@CancId", CanId.Text);
                    cmd.Parameters.AddWithValue("@TicId", TidCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Flcode", FcodeTb.Text);
                    cmd.Parameters.AddWithValue("@CancDate", CancDate.Value.ToString("yyyy-MM-dd"));


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Canelled Successfully");
                    Con.Close();

                    populate();
                    deleteTicket();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                    {
                        MessageBox.Show("Duplicate CancId Please enter a unique CancId");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                finally
                {
                    Con.Close();
                }

            }
        }

        private void CancelRefresh_btn_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");
            Con.Open();

            SqlCommand sql = new SqlCommand("select * from CancelTbl", Con);
            SqlDataAdapter ds = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            ds.Fill(dt);
            CancelDGV.DataSource = dt;
        }

        private void CancResetTicket_btn_Click(object sender, EventArgs e)
        {
            CanId.Clear();
            FcodeTb.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancTicketBack_btn_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Show();
            this.Close();
        }
    }
}
