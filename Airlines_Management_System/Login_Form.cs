using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Airline_Management_System
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtuser.Text) || string.IsNullOrEmpty(txtpass.Text) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a valid user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM admin WHERE username=@username AND password=@password", con);
                cmd.Parameters.AddWithValue("@username", txtuser.Text);
                cmd.Parameters.AddWithValue("@password", txtpass.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                string cmbItemValue = comboBox1.SelectedItem.ToString();

                if (dt.Rows.Count > 0)
                {
                    bool userTypeMatch = false;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["type"].ToString() == cmbItemValue)
                        {
                            userTypeMatch = true;
                            MessageBox.Show("You are logged in as " + dt.Rows[i]["username"].ToString());

                            if (comboBox1.SelectedIndex == 0)
                            {
                                Home hm = new Home();
                                hm.Show();
                                this.Hide();
                            }
                            else if (comboBox1.SelectedIndex == 1)
                            {
                                UserManagement um = new UserManagement();
                                um.Show();
                                this.Hide();
                            }
                            else
                            {
                                sellerManage ts = new sellerManage();
                                ts.Show();
                                this.Hide();
                            }
                        }
                    }

                    if (!userTypeMatch)
                    {
                        throw new Exception("Invalid user type selected");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void login_registerHere_Click(object sender, EventArgs e)
        {
            Signup_Form sg = new Signup_Form();
            sg.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBack_btn_Click(object sender, EventArgs e)
        {
            Signup_Form sg = new Signup_Form();
            sg.Show();
            this.Hide();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();
            
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPass.Checked == true)
            {
                txtpass.UseSystemPasswordChar = true;
            }
            else
            {
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ForgetMethod fm = new ForgetMethod();
            fm.Show();
            this.Hide();
        }
    }
}
