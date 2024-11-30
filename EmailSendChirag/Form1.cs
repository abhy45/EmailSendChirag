using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailSendChirag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Email();
        }


        private void Email()
        {
            // Create SMTP client and set credentials
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 587;
            smtpServer.Credentials = new NetworkCredential("abhysri76752@gmail.com", "igzy tiaw ohms kucu"); // password: bksh oemh wuxd enho  // yahan prr send message ka la email
            smtpServer.EnableSsl = true;

            // Create MailMessage
            MailMessage mail = new MailMessage
            {
                From = new MailAddress("abhysri76752@gmail.com"),  //  yahan prr send message ka la email
                Subject = "Timepass chirag bhaiya",
                Body = "kya ouehrorr rrorh  udu sab maja main bhai haal hai"
            };
            mail.To.Add("Chiragnegi02@gmail.com");

            // Send email
            try
            {
                smtpServer.Send(mail);
                Console.WriteLine("Email sent successfully.");
                MessageBox.Show("send email succeesfully"); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
                MessageBox.Show(ex.Message);

            }

            Console.ReadLine(); // Wait for user to press enter before exiting
        }




    }
}
