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
    public partial class AccessForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");
        public AccessForm()
        {
            InitializeComponent();
        }

        private void AccessAdmin_btn_Click(object sender, EventArgs e)
        {
           Signup sg = new Signup();
            sg.Show();
            this.Hide();
        }

        private void AccessSeller_btn_Click(object sender, EventArgs e)
        {
            Signup sg2 = new Signup();
            sg2.Show();
            this.Hide();
        }

        private void AccessUser_btn_Click(object sender, EventArgs e)
        {
            Signup sg3 = new Signup();
            sg3.Show();
            this.Hide();
        }
    }
}
