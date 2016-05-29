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
using System.ComponentModel;

namespace GestioneLibroSoci
{
    public partial class InviaSMS : Form
    {
        public List<DateTime> date_inizio;
        public List<DateTime> date_fine;
        public List<int> id_Iscrizioni;

        public List<string> cellulari, cognomi, nomi;

        static string[] Scopes = { GmailService.Scope.GmailSend, Google.Apis.Oauth2.v2.Oauth2Service.Scope.UserinfoProfile, Google.Apis.Oauth2.v2.Oauth2Service.Scope.UserinfoEmail };
        static string ApplicationName = "librosoci";
        public InviaSMS()
        {
            InitializeComponent();
            CaricaStagioni();
        }

        private void txtMessaggio_TextChanged(object sender, EventArgs e)
        {
            int caratteri = txtMessaggio.Text.Length;
            caratteriDisponibili.Text = caratteri.ToString() + "/160";
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
            info.Text = "Invio sms in corso...";
            Invio.RunWorkerAsync();
        }

        private void Invio_DoWork(object sender, DoWorkEventArgs e)
        {
            string utente, passwordUtente, id;
            string cartella = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            StreamReader sr = new StreamReader(cartella + "\\LibroSoci\\sms.ini");
            try
            {
                string tmp = sr.ReadLine();
                sr.Close();
                string[] parti = tmp.Split(';');
                id = parti[0];
                utente = parti[1];
                passwordUtente = parti[2];

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

                info.Text = "Invio sms in corso...";
                try
                {
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress(userMail);
                        mail.To.Add("sms@messaging.clickatell.com");
                        StringBuilder st = new StringBuilder();
                        st.AppendLine("api_id:" + id);
                        st.AppendLine("user:" + utente);
                        st.AppendLine("password:" + passwordUtente);
                        for (int i = 0; i < cellulari.Count; i++)
                            st.AppendLine("to:+39" + cellulari[i]);
                        st.AppendLine("text:" + txtMessaggio.Text);
                        st.AppendLine("reply:" + userMail);

                        mail.Body = st.ToString();

                        MimeMessage message = MimeMessage.CreateFromMailMessage(mail);

                        var result = service.Users.Messages.Send(new Google.Apis.Gmail.v1.Data.Message { Raw = Base64UrlEncode(message.ToString()) }, "me").Execute();
                    info.Text = "SMS inviati";
                        contaInviati++;
                    
                    MessageBox.Show("SMS inviati correttamente");
                }
                catch
                {
                    MessageBox.Show("Errore durante l'invio");
                    info.Text = "";
                }
            }

            catch (Exception ex) { MessageBox.Show("Errore " + ex.Message + ex.Data, "Errore invio", MessageBoxButtons.OK, MessageBoxIcon.Error); };
        }

        private static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes)
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");
        }

        private void cmbStagione_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaNumeri.Items.Clear();
            cellulari = new List<string>();
            cognomi = new List<string>();
            nomi = new List<string>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT DISTINCT Cellulare, Cognome, Nome FROM Socio,Iscrizione,Rinnovo WHERE ID_Iscrizione=" + id_Iscrizioni[cmbStagione.SelectedIndex] + " AND ID_Socio=IDSocio AND Email != '' AND IDIscrizione=ID_Iscrizione AND DATALENGTH(Cellulare)>=9";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cellulari.Add(dr["Cellulare"].ToString());
                cognomi.Add(dr["Cognome"].ToString());
                nomi.Add(dr["Nome"].ToString());
            }

            dr.Close();
            conn.Close();

            for (int i = 0; i < cellulari.Count; i++)
            {
                listaNumeri.Items.Add(cellulari[i]+" "+cognomi[i]+" "+nomi[i]);
            }
        }

        private void btnCancellaNumero_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listaNumeri.SelectedIndex;
                listaNumeri.Items.RemoveAt(index);
                cellulari.RemoveAt(index);
                nomi.RemoveAt(index);
                cognomi.RemoveAt(index);
                listaNumeri.SelectedIndex = index;
            }
            catch { ;}
        }

        private void Invio_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }
    }
}
