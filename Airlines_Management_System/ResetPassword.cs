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

namespace Airline_Management_System
{
    public partial class ResetPassword : Form
    {
        string email = SendCode.to;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)  // back btn
        {
            Login_Form lf = new Login_Form();
            lf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox2.Text;
            if(textBox1.Text == password)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");
                string q = "update [admin] set [password] = '" + password + "' where email = '" + email + "'";
                SqlCommand cmd = new SqlCommand(q, con);

                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Password Successfully Changed");

            }

            else
            {
                MessageBox.Show("Sorry!! Your New Password And Confirm Password not matched");
            }
           
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
