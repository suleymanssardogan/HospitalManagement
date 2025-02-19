using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Hospital_Management
{
    public partial class E_Mail : Form
    {
        private List<string> selectedFiles = new List<string>();
        public E_Mail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

           
            
        }

        private void E_Mail_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {

            if (txtTo.Text == null || txtYourMail.Text == null || txtMessage.Text == null)
            {
                MessageBox.Show("Please Fill Necessary Fields");
            }
            else
            {
                //I take from user every necessary info and I assigned new value
                string my_mail = txtYourMail.Text.Trim();
                string to = txtTo.Text.Trim();
                string subject = txtSubject.Text.Trim();
                string message = txtMessage.Text.Trim();
                try
                {

                    //Smtp protocol syntax
                    SmtpClient client = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new System.Net.NetworkCredential(my_mail, "qzif wgmq ibyc hlsx"),
                        EnableSsl = true

                    };
                    MailMessage mail = new MailMessage();


                    //Mail sender syntax
                    mail.From = new MailAddress(my_mail);
                    mail.To.Add(to);
                    mail.Subject = subject;
                    mail.Body = message;
                    mail.IsBodyHtml = false;
                    foreach (string filePath in selectedFiles)
                    {
                        Attachment attachment = new Attachment(filePath);
                        mail.Attachments.Add(attachment);
                    }
                    client.Send(mail);
                  
                    MessageBox.Show("Mail Has Been Sent");
                    selectedFiles.Clear();


                    /* MailMessage mail = new MailMessage
                     {
                         From = new MailAddress(my_mail),
                         Subject = subject,
                         Body = message,
                         IsBodyHtml = false
                     };

                     string[] recipients = to.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                     foreach(string recipient in recipients)
                     {
                         mail.To.Add(recipient.Trim()); // Her bir e-posta adresini ekle
                     }

                     client.Send(mail);
                     MessageBox.Show("Mail Has Been Sent");*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error {ex.Message}");
                }
            }


        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "PDF and Image Files|*.pdf;*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*",
            };
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach(string file in openFileDialog.FileNames)
                {
                    selectedFiles.Add(file);
                    listBoxFile.Items.Add(file);
                }
            }
        }
    }
}
