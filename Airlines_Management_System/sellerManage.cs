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
    public partial class sellerManage : Form
    {
        public sellerManage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket ts = new Ticket();
            ts.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CancellationTbl cs = new CancellationTbl();
            cs.Show();
            this.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login_Form lg = new Login_Form();
            lg.Show();
            this.Close();
        }
    }
}
