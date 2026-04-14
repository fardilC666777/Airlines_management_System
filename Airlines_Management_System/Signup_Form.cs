using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;

namespace Airline_Management_System
{
    public partial class Signup_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bahauddin Sakib\OneDrive\Documents\AirlineDb.mdf"";Integrated Security=True;Connect Timeout=30");

        public Signup_Form()
        {
            InitializeComponent();
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(signUp_Email.Text) || string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(type.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!signUp_Email.Text.Contains("@"))
            {
                MessageBox.Show("Invalid email address. Please include '@' in the email", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!IsStrongPassword(password.Text))
                {
                    MessageBox.Show("Password must be at least 8 characters long and include uppercase letter, lowercase letter, and at least one of the following characters: @, #, $",
                        "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();

                        
                        string checkUsernameQuery = "SELECT COUNT(*) FROM admin WHERE username = @username";
                        using (SqlCommand checkUsernameCmd = new SqlCommand(checkUsernameQuery, con))
                        {
                            checkUsernameCmd.Parameters.AddWithValue("@username", name.Text.Trim());
                            int usernameCount = (int)checkUsernameCmd.ExecuteScalar();
                            if (usernameCount > 0)
                            {
                                MessageBox.Show(name.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        string email = signUp_Email.Text.Trim().ToLower();
                        if (email.Any(char.IsUpper))
                        {
                            MessageBox.Show("Email must be entirely in lowercase.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        email = email.ToLower();

                        string checkEmailQuery = "SELECT COUNT(*) FROM admin WHERE email = @email";
                        using (SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, con))
                        {
                            checkEmailCmd.Parameters.AddWithValue("@email", signUp_Email.Text.Trim());
                            int emailCount = (int)checkEmailCmd.ExecuteScalar();
                            if (emailCount > 0)
                            {
                                MessageBox.Show("Email " + signUp_Email.Text.Trim() + " is already registered", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        string insertData = "INSERT INTO admin (email, username, password, date_created, type) " +
                                            "VALUES (@email, @username, @password, @date_created, @type)";

                        DateTime date = DateTime.Today;
                        using (SqlCommand cmd = new SqlCommand(insertData, con))
                        {
                            cmd.Parameters.AddWithValue("@email", signUp_Email.Text.Trim());
                            cmd.Parameters.AddWithValue("@username", name.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", password.Text.Trim());
                            cmd.Parameters.AddWithValue("@date_created", date);
                            cmd.Parameters.AddWithValue("@type", type.Text.Trim());

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registered successfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Login_Form f1 = new Login_Form();
                            f1.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to the database: " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private bool IsStrongPassword(string password)
        {
            
            if (password.Length < 8 || !Regex.IsMatch(password, "[A-Z]") || !Regex.IsMatch(password, "[a-z]") ||
                !Regex.IsMatch(password, "[@#$]"))
            {
                return false;
            }

            return true;
        }
        private void signup_loginHere_Click(object sender, EventArgs e)
        {
            Login_Form fr = new Login_Form();
            fr.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signupBack_btn_Click(object sender, EventArgs e)
        {
            Login_Form lg = new Login_Form();
            lg.Show();
            this.Hide();
        }

        private void signUpReset_btn_Click(object sender, EventArgs e)
        {
            signUp_Email.Clear();
            name.Clear();   
            password.Clear();
            type.Clear();
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showPass.Checked == true)
            {
                password.UseSystemPasswordChar = true;
            }
            else
            {
                password.UseSystemPasswordChar = false;
            }
        }
    }
}

