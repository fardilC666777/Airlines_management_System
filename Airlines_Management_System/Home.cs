using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void home_backBtn_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Show();
            this.Hide();
        }

        private void home_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightInf flight = new FlightInf();
            flight.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserManagement um = new UserManagement();
            um.Show();
            this.Hide();
        }

        private void Tickets_btn_Click(object sender, EventArgs e)
        {
            sellerManage sm = new sellerManage();
            sm.Show();
            this.Hide();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            CancellationTbl cl = new CancellationTbl();
            cl.Show();
            this.Hide();
        }
    }
}
