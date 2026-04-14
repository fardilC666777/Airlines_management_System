using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Airline_Management_System
{
    public partial class Signup : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");

        public Signup()
        {
            InitializeComponent();
        }

        private void signup_loginHere_Click(object sender, EventArgs e)
        {
            Login lform = new Login();
            lform.Show();
            this.Hide();
        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_reset_Click(object sender, EventArgs e)
        {
            signup_email.Clear();
            signup_password.Clear();
            signup_username.Clear();
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showPass.Checked == true)
            {
                signup_password.UseSystemPasswordChar = true;
            }
            else
            {
                signup_password.UseSystemPasswordChar = false;
            }
        }

        private void register_back_Click(object sender, EventArgs e)
        {
            Login l2form = new Login();
            l2form.Show();
            this.Hide();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_email.Text == "" || signup_username.Text == "" || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    
                    string checkUsernameQuery = "SELECT COUNT(*) FROM admin WHERE username = @username";
                    using (SqlCommand checkUserCmd = new SqlCommand(checkUsernameQuery, connect))
                    {
                        checkUserCmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                        int userCount = (int)checkUserCmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show(signup_username.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                           
                            string checkEmailQuery = "SELECT COUNT(*) FROM admin WHERE email = @email";
                            using (SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, connect))
                            {
                                checkEmailCmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                int emailCount = (int)checkEmailCmd.ExecuteScalar();

                                if (emailCount > 0)
                                {
                                    MessageBox.Show(signup_email.Text + " is already registered", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                
                                    string insertDataQuery = "INSERT INTO admin(email, username, password, date_created) " +
                                                             "VALUES(@email, @username, @pass, @date)";

                                    DateTime date = DateTime.Today;

                                    using (SqlCommand insertCmd = new SqlCommand(insertDataQuery, connect))
                                    {
                                        insertCmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                        insertCmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                        insertCmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                                        insertCmd.Parameters.AddWithValue("@date", date);

                                        insertCmd.ExecuteNonQuery();
                                        MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        Login lForm = new Login();     
                                        lForm.Show();
                                        this.Hide();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
    }
}

