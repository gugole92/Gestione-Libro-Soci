using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Data.Odbc;
using System.Configuration;

namespace GestioneLibroSoci
{
    public partial class InviaMail : Form
    {
        public List<DateTime> date_inizio;
        public List<DateTime> date_fine;
        public List<int> id_Iscrizioni;

        public List<string> destinatari;
        public List<string> cognomi, nomi, codici, tessere;

        public List<string> inviati;

        public bool completato;

        public InviaMail()
        {
            InitializeComponent();
            CaricaStagioni();
        }

        public void CaricaStagioni()
        {
            date_inizio = new List<DateTime>();
            date_fine = new List<DateTime>();
            id_Iscrizioni = new List<int>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT * FROM Iscrizione";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                date_inizio.Add(DateTime.Parse(dr["Data_inizio"].ToString()));
                date_fine.Add(DateTime.Parse(dr["Data_fine"].ToString()));
                id_Iscrizioni.Add(int.Parse(dr["ID_Iscrizione"].ToString()));
            }
            dr.Close();
            conn.Close();

            for (int i = 0; i < date_inizio.Count; i++)
            {
                cmbStagione.Items.Add(date_inizio[i].ToShortDateString() + " - " + date_fine[i].ToShortDateString());
            }
            if (cmbStagione.Items.Count > 0)
                cmbStagione.SelectedIndex = cmbStagione.Items.Count - 1;
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            info.Text = "Invio email in corso...";
            barra.Style = ProgressBarStyle.Marquee;
            Invio.RunWorkerAsync();

            //string email, password;
            //string cartella = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            //StreamReader sr = new StreamReader(cartella + "\\LibroSoci\\account.ini");
            //try
            //{
            //    string tmp = sr.ReadLine();
            //    sr.Close();
            //    string[] parti = tmp.Split(';');
            //    email = parti[0];
            //    password = parti[1];

            //    SmtpClient client = new SmtpClient();
            //    client.Port = 587;
            //    client.Host = "smtp.gmail.com";
            //    client.EnableSsl = true;
            //    client.Timeout = 10000;
            //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //    client.UseDefaultCredentials = false;
            //    client.Credentials = new System.Net.NetworkCredential(email, password);

            //    for (int i = 0; i < destinatari.Count; i++)
            //    {
            //        MailMessage mail = new MailMessage();
            //        mail.From = new MailAddress(email, "Liscio Club Eventi");
            //        mail.To.Add(destinatari[i]);
            //        mail.Subject = txtOggetto.Text;
            //        string tmpMEX = txtMessaggio.Text;
            //        tmpMEX = tmpMEX.Replace("<NOME>", nomi[i]);
            //        tmpMEX = tmpMEX.Replace("<COGNOME>", cognomi[i]);
            //        tmpMEX = tmpMEX.Replace("<TESSERA>", tessere[i]);
            //        tmpMEX = tmpMEX.Replace("<CODICE>", codici[i]);
            //        tmpMEX = tmpMEX.Replace("\r\n", "<br>");


            //        string htmlBody = "<html><body><img src=\"cid:logo\"><br><br><br><p>" + tmpMEX + "</p><br><h6>" + txtPivacy.Text + "</h6></body></html>";
            //        AlternateView avHtml = AlternateView.CreateAlternateViewFromString(htmlBody, null, "text/html");
            //        LinkedResource logo = new LinkedResource("intestazione.jpg", System.Net.Mime.MediaTypeNames.Image.Jpeg);
            //        logo.ContentId = "logo";
            //        avHtml.LinkedResources.Add(logo);
            //        mail.AlternateViews.Add(avHtml);

            //        client.Send(mail);
            //       // listaMail.SelectedIndex = i;
            //    }

            //    MessageBox.Show("Sono state inviate " + destinatari.Count + " email");
            //    this.Close();
            //}

            //catch (Exception ex) { MessageBox.Show("Errore " + ex.Message + ex.Data, "Errore invio", MessageBoxButtons.OK, MessageBoxIcon.Error); };
        }

        private void cmbStagione_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaMail.Items.Clear();
            inviati = new List<string>();
            destinatari = new List<string>();
            nomi = new List<string>();
            cognomi = new List<string>();
            tessere = new List<string>();
            codici = new List<string>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT DISTINCT Nome,Cognome,Tessera,Codice,Email FROM Socio,Iscrizione,Rinnovo WHERE ID_Iscrizione="+id_Iscrizioni[cmbStagione.SelectedIndex]+" AND ID_Socio=IDSocio AND Email != '' AND IDIscrizione=ID_Iscrizione";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                destinatari.Add(dr["Email"].ToString());
                nomi.Add(dr["Nome"].ToString());
                cognomi.Add(dr["Cognome"].ToString());
                tessere.Add(dr["Tessera"].ToString());
                codici.Add(dr["Codice"].ToString());
            }

            dr.Close();
            conn.Close();

            for (int i = 0; i < destinatari.Count; i++)
            {
                listaMail.Items.Add(destinatari[i]);
            }
        }

        private void tags_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtMessaggio.Text = txtMessaggio.Text.Insert(txtMessaggio.SelectionStart, tags.Items[tags.SelectedIndex].ToString());
        }

        private void btnCancellaEmail_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listaMail.SelectedIndex;
                listaMail.Items.RemoveAt(index);
                destinatari.RemoveAt(index);
                nomi.RemoveAt(index);
                cognomi.RemoveAt(index);
                tessere.RemoveAt(index);
                codici.RemoveAt(index);
                listaMail.SelectedIndex = index;
            }
            catch { ;}
        }


        private void Invio_DoWork(object sender, DoWorkEventArgs e)
        {
            string email, password;
            string cartella = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            StreamReader sr = new StreamReader(cartella + "\\LibroSoci\\account.ini");
            try
            {
                string tmp = sr.ReadLine();
                sr.Close();
                string[] parti = tmp.Split(';');
                email = parti[0];
                password = parti[1];

                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                  System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate(object s,
                        System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                        System.Security.Cryptography.X509Certificates.X509Chain chain,
                        System.Net.Security.SslPolicyErrors sslPolicyErrors)
                  {
                      return true;
                  };

                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(email, password);

                for (int i = 0; i < destinatari.Count; i++)
                {
                    // info.Text = "Invio email " + i + " di " + destinatari.Count;
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(email, "Liscio Club Eventi");
                    mail.To.Add(destinatari[i]);
                    mail.Subject = txtOggetto.Text;
                    string tmpMEX = txtMessaggio.Text;
                    tmpMEX = tmpMEX.Replace("<NOME>", nomi[i]);
                    tmpMEX = tmpMEX.Replace("<COGNOME>", cognomi[i]);
                    tmpMEX = tmpMEX.Replace("<TESSERA>", tessere[i]);
                    tmpMEX = tmpMEX.Replace("<CODICE>", codici[i]);
                    tmpMEX = tmpMEX.Replace("\r\n", "<br>");


                    string htmlBody = "<html><body><img src=\"cid:logo\"><br><br><br><p>" + tmpMEX + "</p><br><h6>" + txtPivacy.Text + "</h6></body></html>";
                    AlternateView avHtml = AlternateView.CreateAlternateViewFromString(htmlBody, null, "text/html");
                    LinkedResource logo = new LinkedResource("intestazione.jpg", System.Net.Mime.MediaTypeNames.Image.Jpeg);
                    logo.ContentId = "logo";
                    avHtml.LinkedResources.Add(logo);
                    mail.AlternateViews.Add(avHtml);

                    client.Send(mail);

                    // listaMail.SelectedIndex = i;
                }

                MessageBox.Show("Sono state inviate " + destinatari.Count + " email");


            }

            catch (Exception ex) { MessageBox.Show("Errore " + ex.Message + ex.Data, "Errore invio", MessageBoxButtons.OK, MessageBoxIcon.Error); };
        }

        private void Invio_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

           this.Close();
        }

    }
}
