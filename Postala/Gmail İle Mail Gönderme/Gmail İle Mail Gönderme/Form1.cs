using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Gmail_İle_Mail_Gönderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage mesaj = new MailMessage();
                mesaj.To.Add(txtAliciEMail.Text);
                mesaj.From = new MailAddress(txtGondericiGMailAdres.Text);
                mesaj.Subject = txtMesajKonusu.Text;
                mesaj.Body = txtMesaj.Text;
                NetworkCredential guvenlik = new NetworkCredential(txtGondericiGMailAdres.Text, txtGondericiGMailSifre.Text);
                client.Credentials = guvenlik;
                client.EnableSsl = true;
                client.Send(mesaj);
                MessageBox.Show("Mail Başarıyla Gönderildi.", "Mail Gönderme");
            }
            catch
            {
                MessageBox.Show("Mail Gönderme Başarısız.", "Mail Gönderme");
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Volkan Yıldırım tarafından geliştirilmiştir. http://www.volkanyildirimvy.com");
        }

        private void kapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
           
        }

        private void sürümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İlk güncellemedir. (v1) Hata ve görüşleriniz için ; volkanyildrim@gmail.com");
        }
    }
    
}