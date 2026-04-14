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
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
        }

        private void login_registerHere_Click(object sender, EventArgs e)
        {
            Signup sForm = new Signup();
            sForm.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_reset_Click(object sender, EventArgs e)
        {
            login_username.Clear();
            login_password.Clear();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPass.Checked == true)
            {
                login_password.UseSystemPasswordChar = true;
            }
            else
            {
                login_password.UseSystemPasswordChar = false;
            }
        }

        private void back_login_Click(object sender, EventArgs e)
        {
            Signup s2Form = new Signup();
            s2Form.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(login_username.Text=="" ||  login_password.Text=="")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if(connect.State != ConnectionState.Open) 
                {
                    try
                    {

                        connect.Open();

                        string selectData = "SELECT * FROM admin WHERE username= @username AND password= @pass";
                        using(SqlCommand cmd =  new SqlCommand(selectData,connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text);
                            cmd.Parameters.AddWithValue("@pass", login_password.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >=1)
                            {
                               // MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Home hmForm = new Home();
                                hmForm.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Incorrect Usename/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("Error Connecting:" +ex , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally 
                    {
                      connect.Close();
                    }
                }
            }
        }
    }
}

