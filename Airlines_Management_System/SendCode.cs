using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Management_System
{
    public partial class SendCode : Form
    {
        private string randomCode;
        public static string to;

        public SendCode()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ForgetMethod fm = new ForgetMethod();
            fm.Show();
            this.Hide();
        }

        private async void button2_Click(object sender, EventArgs e) // send code btn
        {
            try
            {
                EmailSender emailSender = new EmailSender();
                randomCode = emailSender.GenerateRandomCode();
                to = textBox1.Text;

                await emailSender.SendEmailAsync(to, randomCode);

                MessageBox.Show("Code Successfully Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e) // verify code btn
        {
            if (randomCode == textBox2.Text)
            {
                to = textBox1.Text;
                ResetPassword rp = new ResetPassword();
                rp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You Entered Wrong Code");
            }
        }

        private void SendCode_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

    public class EmailSender
    {
        public string GenerateRandomCode()
        {
            Random rand = new Random();
            return rand.Next(999999).ToString();
        }

        public async Task SendEmailAsync(string to, string randomCode)
        {
            string from = "bahauddinsakib2023@gmail.com";
            string pass = "hrkl evig lbal ydms";
            string messageBody = $"Your Reset Code is {randomCode}";

            MailMessage message = new MailMessage
            {
                To = { to },
                From = new MailAddress(from),
                Body = messageBody,
                Subject = "Password Reset Code"
            };

            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                EnableSsl = true,
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(from, pass)
            };

            await smtp.SendMailAsync(message);
        }
    }
}
