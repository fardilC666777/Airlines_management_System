using System;
using System.Windows.Forms;

namespace Airline_Management_System
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Interval = 16;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                
                OpenLoginForm();
            }
        }

        private void OpenLoginForm()
        {
            Login_Form lf = new Login_Form();
            lf.Show();           
            this.Hide();
        }

        private void Loading_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

