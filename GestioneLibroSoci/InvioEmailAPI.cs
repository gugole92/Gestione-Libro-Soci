using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using MimeKit;
using MailBee;
using MailBee.ImapMail;
using System.Data.Odbc;
using System.Configuration;

namespace GestioneLibroSoci
{
    public partial class InvioEmailAPI : Form
    {
        static string[] Scopes = { GmailService.Scope.GmailSend, Google.Apis.Oauth2.v2.Oauth2Service.Scope.UserinfoProfile, Google.Apis.Oauth2.v2.Oauth2Service.Scope.UserinfoEmail};
        static string ApplicationName = "librosoci";

        public List<DateTime> date_inizio;
        public List<DateTime> date_fine;
        public List<int> id_Iscrizioni;

        public List<string> destinatari;
        public List<string> cognomi, nomi, codici, tessere;
        public InvioEmailAPI()
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

        private void cmbStagione_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaMail.Items.Clear();
            destinatari = new List<string>();
            nomi = new List<string>();
            cognomi = new List<string>();
            tessere = new List<string>();
            codici = new List<string>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT DISTINCT Nome,Cognome,Tessera,Codice,Email FROM Socio,Iscrizione,Rinnovo WHERE ID_Iscrizione=" + id_Iscrizioni[cmbStagione.SelectedIndex] + " AND ID_Socio=IDSocio AND Email != '' AND IDIscrizione=ID_Iscrizione";
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
            catch {; }
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {

            Invio.RunWorkerAsync();
           // Task.WaitAll(InvioEmail());
        }

        public async Task InvioEmail()
        {

            int contaInviati = 1;
            info.Text = "Richiesta autorizzazione Gmail...";

            UserCredential credential;

            using (var stream =
                 new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart.json");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;

            }

            if (credential.Token.IsExpired(credential.Flow.Clock))
            {
                if (credential.RefreshTokenAsync(CancellationToken.None).Result)
                    info.Text = "Accesso a Gmail ottenuto";
                else
                {
                    info.Text = "Accesso a Gmail negato";
                }
            }

            else info.Text = "Accesso a Gmail ottenuto";

            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            Google.Apis.Oauth2.v2.Oauth2Service oauthService = new Google.Apis.Oauth2.v2.Oauth2Service(new BaseClientService.Initializer() { HttpClientInitializer = credential });
            Google.Apis.Oauth2.v2.Data.Userinfoplus userInfo = oauthService.Userinfo.Get().ExecuteAsync().Result;
            string userMail = userInfo.Email;
            string userName = userInfo.Name;

            info.Text = "Invio email in corso...";
            try
            {
                for (int i = 0; i < destinatari.Count; i++)
                {

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(userMail, userName);
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

                    MimeMessage message = MimeMessage.CreateFromMailMessage(mail);

                    var result = service.Users.Messages.Send(new Google.Apis.Gmail.v1.Data.Message { Raw = Base64UrlEncode(message.ToString()) }, "me").Execute();
                    info.Text = "Inviate " + contaInviati.ToString() + " di " + destinatari.Count + " ID " + result.Id;
                    contaInviati++;
                }
                MessageBox.Show("Email inviate correttamente");
            }
            catch
            {
                MessageBox.Show("Errore durante l'invio");
                info.Text = "";
            }

        }

        private void Invio_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int contaInviati = 1;
            info.Text = "Richiesta autorizzazione Gmail...";
            try
            {
                UserCredential credential;

            using (var stream =
                 new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart.json");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            if (credential.Token.IsExpired(credential.Flow.Clock))
            {
                if (credential.RefreshTokenAsync(CancellationToken.None).Result)
                    info.Text = "Accesso a Gmail ottenuto";
                else
                {
                    info.Text = "Accesso a Gmail negato";
                    return;
                }
            }

            else info.Text = "Accesso a Gmail ottenuto";

            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            Google.Apis.Oauth2.v2.Oauth2Service oauthService = new Google.Apis.Oauth2.v2.Oauth2Service(new BaseClientService.Initializer() { HttpClientInitializer = credential });
            Google.Apis.Oauth2.v2.Data.Userinfoplus userInfo = oauthService.Userinfo.Get().ExecuteAsync().Result;
            string userMail = userInfo.Email;
            string userName = userInfo.Name;

            info.Text = "Invio email in corso...";
           
                for (int i = 0; i < destinatari.Count; i++)
                {

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(userMail, userName);
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

                    MimeMessage message = MimeMessage.CreateFromMailMessage(mail);

                    var result = service.Users.Messages.Send(new Google.Apis.Gmail.v1.Data.Message { Raw = Base64UrlEncode(message.ToString()) }, "me").Execute();
                    info.Text = "Inviate " + contaInviati.ToString() + " di " + destinatari.Count + " ID " + result.Id;
                    contaInviati++;
                }
                MessageBox.Show("Email inviate correttamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'invio "+ex.InnerException);
                info.Text = "";
            }
        }

        private void Invio_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        public void AccediAPI()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart.json");
                MessageBox.Show(credPath);
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;

            }

            if(credential.Token.IsExpired(credential.Flow.Clock))
            {

            }

            // Create Gmail API service.
            var service = new GmailService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

            Google.Apis.Oauth2.v2.Oauth2Service oauthService = new Google.Apis.Oauth2.v2.Oauth2Service(new BaseClientService.Initializer() { HttpClientInitializer = credential });
            Google.Apis.Oauth2.v2.Data.Userinfoplus userInfo = oauthService.Userinfo.Get().ExecuteAsync().Result;
            string userMail = userInfo.Email;
            string userName = userInfo.Name;
            //var userinfo = service.Users.GetProfile("me");

            // Define parameters of request.
            //UsersResource.LabelsResource.ListRequest request = service.Users.Labels.List("me");


            // List labels.
            //IList<Google.Apis.Gmail.v1.Data.Label> labels = request.Execute().Labels;
            //Console.WriteLine("Labels:");
            //if (labels != null && labels.Count > 0)
            //{
            //    foreach (var labelItem in labels)
            //    {
            //       // MessageBox.Show(labelItem.Name);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("no alabel found");
            //}

            //var msg = new AE.Net.Mail.MailMessage
            //{
            //    Subject = "test invio api",
            //    Body = "Prova di invio",
            //    From = new MailAddress("roberto.gugole@gmail.com")
            //};

            //msg.To.Add(new MailAddress("roberto@gugole.tk"));
            //msg.ReplyTo.Add(msg.From);
            //var msgStr = new StringWriter();
            //msg.Save(msgStr);
            //service.Users.Messages.Send(new Google.Apis.Gmail.v1.Data.Message { Raw = Base64UrlEncode(msgStr.ToString()) }, "me").Execute();




            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(userMail, userName);
            mail.To.Add("roberto@gugole.tk");
            mail.Subject = "prova";
            


            string htmlBody = "<html><body><img src=\"cid:logo\"><br><br><br><p>" + "test" + "</p><br></body></html>";
            AlternateView avHtml = AlternateView.CreateAlternateViewFromString(htmlBody, null, "text/html");
            LinkedResource logo = new LinkedResource("intestazione.jpg", System.Net.Mime.MediaTypeNames.Image.Jpeg);
            logo.ContentId = "logo";
            avHtml.LinkedResources.Add(logo);
            mail.AlternateViews.Add(avHtml);

            MimeMessage message = MimeMessage.CreateFromMailMessage(mail);

            var result = service.Users.Messages.Send(new Google.Apis.Gmail.v1.Data.Message { Raw = Base64UrlEncode(message.ToString()) }, "me").Execute();
            MessageBox.Show("message id" + result.Id);
        }

         private static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes)
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //var msg = new AE.Net.Mail.MailMessage
            //{
            //    Subject = "test invio api",
            //    Body = "Prova di invio",
            //    From = new MailAddress("roberto.gugole@gmail.com")
            //};

            //msg.To.Add(new MailAddress("roberto@gugole.tk"));
            //var msgStr = new StringWriter();
            //msg.Save(msgStr);

            //var service = new GmailService(new BaseClientService.Initializer()
            //{
            //    HttpClientInitializer = credential,
            //    ApplicationName = ApplicationName,
            //});


        }
    }
}
