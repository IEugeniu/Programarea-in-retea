using OpenPop.Pop3;
using OpenPop.Mime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailManager
{
     public partial class Form2 : Form
     {
          static Pop3Client client = new Pop3Client();
          static List<OpenPop.Mime.Message> allEmails;
          public Form2()
          {
               InitializeComponent();

               GetAllMessages("email address", Utils.Password);

               foreach (var item in allEmails)
               {
                    ListViewItem listViewItem = new ListViewItem(item.Headers.From.ToString());
                    listViewItem.SubItems.Add(item.Headers.Subject);

                    emailList.Items.Add(listViewItem);
               }
          }

          public static void GetAllMessages(string username, string password)
          {
               Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
               client.Connect("pop.mail.ru", 995, true);
               client.Authenticate(username, password);

               allEmails = new List<OpenPop.Mime.Message>();

               OpenPop.Mime.Message message;
               for (int i = 20; i > 0; i--)
               {
                    message = client.GetMessage(i);
                    allEmails.Add(message);
                    Console.WriteLine(message.Headers.From);
               }
          }

          private void listView1_SelectedIndexChanged(object sender, EventArgs e)
          {
               try
               {
                    if (emailList.SelectedItems.Count > 0)
                         emailText.Text = allEmails[emailList.Items.IndexOf(emailList.SelectedItems[0])].MessagePart.MessageParts[0].GetBodyAsText();
                    
               }
               catch(NullReferenceException)
               {
                    emailText.Text = "Email not supported";
               }

          }
     }
}
