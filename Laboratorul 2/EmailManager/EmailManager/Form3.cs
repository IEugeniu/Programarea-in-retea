using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailManager
{
     public partial class Form3 : Form
     {
          public Form3()
          {
               InitializeComponent();
          }

          private void SendButton_Click(object sender, EventArgs e)
          {
               string recipient = RecipientTextBox.Text;
               string subject = SubjectTextBox.Text;
               string message = MessageTextBox.Text;

               SendEmail("email address", Utils.Password, recipient, subject, message);
          }

          public static void SendEmail(string email, string password, string sendEmail, string subject, string body)
          {
               try
               {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.mail.ru");

                    mail.From = new MailAddress(email);
                    mail.To.Add(sendEmail);
                    mail.Subject = subject;
                    mail.Body = body;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(email, password);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Email sent successfully");
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
          }
     }
}
