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
    public partial class ForgetMethod : Form
    {
        public ForgetMethod()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendCode sc = new SendCode();
            sc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
