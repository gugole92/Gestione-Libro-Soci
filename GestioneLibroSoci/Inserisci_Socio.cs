using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Configuration;
using System.Data.OleDb;
using CodiceFiscale;
using System.Collections;

namespace GestioneLibroSoci
{
    public partial class Inserisci_Socio : Form
    {
        public ClsCodiceFiscale calcoloCF;
        ArrayList vetStrErrori;

        public int Tessera;

        public Inserisci_Socio()
        {
            InitializeComponent();
            calcoloCF = new ClsCodiceFiscale();
            GeneraNumeroTessera();

            txtTessera.Text += Tessera.ToString();
        }

        public void GeneraNumeroTessera()
        {
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT MAX(Tessera) FROM Socio";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                Tessera = int.Parse(dr[0].ToString()) + 1;
            }
            dr.Close();
            conn.Close();
        }

        private void txtCitta_Leave(object sender, EventArgs e)
        {
            string strStringaConnessione = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Environment.CurrentDirectory + "\\Comuni.mdb";
            OleDbConnection connessioneDB = new OleDbConnection(strStringaConnessione);
            OleDbCommand commandDB = new OleDbCommand("select Provincia,CAP from comuni WHERE Comune='" + txtCitta.Text.Replace("'", "''") + "'", connessioneDB);
            connessioneDB.Open();

            OleDbDataReader dataReaderDB = commandDB.ExecuteReader();
            if (dataReaderDB.Read())
            {
                txtProvResidenza.Text = dataReaderDB.GetString(dataReaderDB.GetOrdinal("Provincia"));
                txtCap.Text = dataReaderDB.GetString(dataReaderDB.GetOrdinal("CAP"));
            }

            dataReaderDB.Close();
            connessioneDB.Close();
        }

        private void txtLuogoNascita_Leave(object sender, EventArgs e)
        {
            string strStringaConnessione = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Environment.CurrentDirectory + "\\Comuni.mdb";
            OleDbConnection connessioneDB = new OleDbConnection(strStringaConnessione);
            OleDbCommand commandDB = new OleDbCommand("select Provincia from comuni WHERE Comune='" + txtLuogoNascita.Text.Replace("'", "''") + "'", connessioneDB);
            connessioneDB.Open();

            OleDbDataReader dataReaderDB = commandDB.ExecuteReader();
            if (dataReaderDB.Read())
            {
                txtProvNascita.Text = dataReaderDB.GetString(dataReaderDB.GetOrdinal("Provincia"));
            }

            dataReaderDB.Close();
            connessioneDB.Close();
        }

        private void txtSesso_Leave(object sender, EventArgs e)
        {
            if (txtCF.Text == "")
            {
                vetStrErrori = new ArrayList();
                try
                {
                    string codiceFiscale = calcoloCF.CalcolaCF(txtNome.Text, txtCognome.Text, char.Parse(txtSesso.Text), txtDataNascita.Text, txtLuogoNascita.Text, txtProvNascita.Text, vetStrErrori);
                    txtCF.Text = codiceFiscale;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "INSERT INTO Socio(Tessera,Codice,Cognome,Nome,Sesso,Nascita,Provincia_Nascita,Data_Nascita,CF,Indirizzo,Frazione,CAP,Comune,Provincia_Residenza,Cellulare,Telefono,Email,Data_Iscrizione) VALUES(" + Tessera.ToString() + ",'" + txtCodice.Text + "','" + txtCognome.Text.Replace("'", "''") + "','" + txtNome.Text.Replace("'", "''") + "','" + txtSesso.Text + "','" + txtLuogoNascita.Text.Replace("'", "''") + "','" + txtProvNascita.Text + "','" + txtDataNascita.Text + "','" + txtCF.Text + "','" + txtVia.Text.Replace("'", "''") + "','" + txtFrazione.Text.Replace("'", "''") + "','" + txtCap.Text + "','" + txtCitta.Text.Replace("'", "''") + "','" + txtProvResidenza.Text + "','" + txtCellulare.Text + "','" + txtTelefono.Text + "','" + txtMail.Text + "','" + DateTime.Now.ToShortDateString() + "')";
            cm.Connection = conn;
            conn.Open();
            cm.ExecuteNonQuery();
            
            
            cm.CommandText = "SELECT MAX(ID_Iscrizione) FROM Iscrizione";
            OdbcDataReader dr = cm.ExecuteReader();
            dr.Read();
            int id_iscrizione = int.Parse(dr[0].ToString());
            dr.Close();

            cm.CommandText = "SELECT ID_Socio FROM Socio WHERE Tessera=" + Tessera;
            dr = cm.ExecuteReader();
            dr.Read();
            int id_socio = int.Parse(dr[0].ToString());
            dr.Close();

            cm.CommandText = "INSERT INTO Rinnovo(IDSocio,IDIscrizione) VALUES(" + id_socio + "," + id_iscrizione + ")";
            cm.ExecuteNonQuery();
            conn.Close();

            StampaModulo.PrintController = new System.Drawing.Printing.StandardPrintController();
            StampaModulo.Print();

            if (MessageBox.Show("Socio inserito nel database. Vuoi inserirne un altro?", "Conferma inserimento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                GeneraNumeroTessera();
                txtTessera.Text = "Tessera n." + Tessera;
                txtCodice.Clear();
                txtCognome.Clear();
                txtNome.Clear();
                txtSesso.Clear();
                txtLuogoNascita.Clear();
                txtProvNascita.Clear();
                txtDataNascita.Clear();
                txtCF.Clear();
                txtVia.Clear();
                txtFrazione.Clear();
                txtCap.Clear();
                txtCitta.Clear();
                txtProvResidenza.Clear();
                txtCellulare.Clear();
                txtTelefono.Clear();
                txtMail.Clear();
                txtCodice.Focus();
            }
            else this.Close();
        }

        private void txtVia_Enter(object sender, EventArgs e)
        {
            txtVia.Text = "Via ";
            txtVia.SelectionStart = txtVia.TextLength - 1;
        }

        private void StampaModulo_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 43;
            Bitmap intestazione = new Bitmap("intestazione.png");
            e.Graphics.DrawImage(intestazione, x, 50);
            FontStyle stile = new FontStyle();
            stile = FontStyle.Bold;
            e.Graphics.DrawString("MODULO D'ISCRIZIONE ALL'ASSOCIAZIONE", new System.Drawing.Font("Arial", 12, stile), Brushes.Black, x + 200, 175);
            e.Graphics.DrawString("Tessera n. " + Tessera, new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 250);
            e.Graphics.DrawString("Cognome: " + txtCognome.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 310);
            e.Graphics.DrawString("Nome: " + txtNome.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 350, 310);
            e.Graphics.DrawString("Indirizzo: " + txtVia.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 353);
            e.Graphics.DrawString("C.a.p. " + txtCap.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 350, 353);
            e.Graphics.DrawString("Città: " + txtCitta.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 450, 353);
            e.Graphics.DrawString("Frazione: " + txtFrazione.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 396);
            e.Graphics.DrawString("Tel. " + txtTelefono.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 439);
            e.Graphics.DrawString("Cell. " + txtCellulare.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 175, 439);
            e.Graphics.DrawString("Email: " + txtMail.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 350, 439);
            e.Graphics.DrawString("Nato a: " + txtLuogoNascita.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 482);
            e.Graphics.DrawString("Prov. (" + txtProvNascita.Text + ")", new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 350, 482);
            e.Graphics.DrawString("il " + txtDataNascita.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 450, 482);
            e.Graphics.DrawString("Cod. Fisc. " + txtCF.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 525);
            e.Graphics.DrawString("Attività svolta: BALLO SOCIALE", new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 568);
            e.Graphics.DrawString("FIRMA   ___________________________", new System.Drawing.Font("Calibri", 11, stile), Brushes.Black, x + 450, 606);
            e.Graphics.DrawString("INFORMATIVA EX ART. 13 D.LGS. 196 PER IL TRATTAMENTO DEI DATI PERSONALI", new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 70, 692);
            e.Graphics.DrawString("La informiamo che, secondo la normativa del D.lgs. n. 196 del 30 giugno 2003, il trattamento dei dati da Lei", new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 725);
            e.Graphics.DrawString("forniti avverrà per la sola comunicazione a Lei diretta di informazioni inerenti iniziative e spettacoli", new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 745);
            e.Graphics.DrawString("esclusivamente da parte dell'A.S.D. LISCIO CLUB.", new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 765);
            e.Graphics.DrawString("DICHIARAZIONE LIBERATORIA DI SANA COSTITUZIONE FISICA", new System.Drawing.Font("Calibri", 11, stile), Brushes.Black, x + 120, 840);
            e.Graphics.DrawString("DICHIARO", new System.Drawing.Font("Calibri", 14, stile), Brushes.Black, x + 300, 890);
            e.Graphics.DrawString("sotto la mia responsabilità di essere di sana e robusta costituzione fisica senza controindicazioni di sorta", new System.Drawing.Font("Calibri", 11, stile), Brushes.Black, x, 940);
            e.Graphics.DrawString("alla pratica da me svolta. Dichiaro inoltre che non sussistono indicazioni mediche che impediscano o", new System.Drawing.Font("Calibri", 11, stile), Brushes.Black, x, 960);
            e.Graphics.DrawString("rendano sconsigliabile o pongano dei limiti a qualsiasi pratica motoria e sportiva in genere anche di", new System.Drawing.Font("Calibri", 11, stile), Brushes.Black, x, 980);
            e.Graphics.DrawString("semplice attività ricreativa da me svolta.", new System.Drawing.Font("Calibri", 11, stile), Brushes.Black, x, 1000);
            e.Graphics.DrawString("Data   ______________", new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 1046);
            e.Graphics.DrawString("FIRMA   ___________________________", new System.Drawing.Font("Calibri", 11, stile), Brushes.Black, x + 450, 1046);
        }
    }
}
