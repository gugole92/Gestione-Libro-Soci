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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace GestioneLibroSoci
{
    public partial class Rinnova_iscrizione : Form
    {
        public int Tessera;

        public int id_iscrizione;

        public string cap;
        public string nascita;
        public string prov_nascita;
        public string dataNascita;
        public string cf;
        public string frazione;
        public float codiceTessera;

        public Rinnova_iscrizione()
        {
            InitializeComponent();

            CercaSocio form = new CercaSocio();
            form.ShowDialog();
            Tessera = form.tesseraSelezionata;
            if (Tessera != 0)
                CaricaSocio();
            else
                this.Close();
        }

        public void CaricaSocio()
        {
            txtTessera.Text += Tessera.ToString();
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT Codice,frazione,CF,Nascita,Provincia_Nascita,Data_nascita,Cap,Cognome,Nome,Indirizzo,Comune,Cellulare,Telefono,Email,Data_fine FROM Socio,Iscrizione,Rinnovo WHERE Tessera=" + Tessera + " AND Rinnovo.IDSocio=Socio.ID_Socio AND Iscrizione.ID_Iscrizione=Rinnovo.IDIscrizione";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                txtCognome.Text = dr["Cognome"].ToString();
                txtNome.Text = dr["Nome"].ToString();
                txtIndirizzo.Text = dr["Indirizzo"].ToString();
                txtCitta.Text = dr["Comune"].ToString();
                txtCellulare.Text = dr["Cellulare"].ToString();
                txtTelefono.Text = dr["Telefono"].ToString();
                txtMail.Text = dr["Email"].ToString();
                lblScadenzaIscrizione.Text += " " + DateTime.Parse(dr["Data_fine"].ToString()).ToShortDateString();
                cap = dr["CAP"].ToString();
                nascita = dr["Nascita"].ToString();
                prov_nascita = dr["Provincia_Nascita"].ToString();
                dataNascita = DateTime.Parse(dr["Data_nascita"].ToString()).ToShortDateString();
                cf = dr["CF"].ToString();
                frazione = dr["frazione"].ToString();
                codiceTessera = float.Parse(dr["Codice"].ToString());
            }
            dr.Close();

            cm.CommandText = "SELECT MAX(Data_fine) FROM Iscrizione";
            dr = cm.ExecuteReader();
            dr.Read();
            txtScadenzaTessera.Text = DateTime.Parse(dr[0].ToString()).ToShortDateString();
            dr.Close();

            cm.CommandText = "SELECT ID_Iscrizione FROM Iscrizione WHERE Data_fine='" + txtScadenzaTessera.Text + "'";
            dr = cm.ExecuteReader();
            dr.Read();
            id_iscrizione = int.Parse(dr["ID_Iscrizione"].ToString());
            dr.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT COUNT(*) FROM Rinnovo WHERE IDSocio=" + Tessera + " AND IDIscrizione=" + id_iscrizione;
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                int conta = int.Parse(dr[0].ToString());
                if (conta > 0)
                {
                    if (MessageBox.Show("Socio già iscritto per questa stagione! Vuoi stampare solo il modulo?", "Stampa modulo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        printDocument1.PrintController = new System.Drawing.Printing.StandardPrintController();
                        printDocument1.Print();
                        this.Close();
                        return;
                    }
                    else
                    {
                        this.Close();
                        return;

                    }
                }

            }
            dr.Close();

            cm.CommandText = "INSERT INTO Rinnovo (IDSocio,IDIscrizione) VALUES (" + Tessera + "," + id_iscrizione + ")";

            cm.ExecuteNonQuery();
            if (MessageBox.Show("Iscrizione rinnovata. Vuoi stampare il modulo?", "Stampa modulo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                printDocument1.PrintController = new System.Drawing.Printing.StandardPrintController();
                printDocument1.Print();
                this.Close();
            }

            else
                this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 43;
            Bitmap intestazione = new Bitmap("intestazione.png");
            e.Graphics.DrawImage(intestazione, x, 50);
            FontStyle stile = new FontStyle();
            stile = FontStyle.Bold;
            e.Graphics.DrawString("MODULO D'ISCRIZIONE ALL'ASSOCIAZIONE", new System.Drawing.Font("Arial", 12, stile), Brushes.Black, x + 200, 175);
            e.Graphics.DrawString("Tessera n. " + Tessera, new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 250);
            e.Graphics.DrawString("Codice tessera: " + codiceTessera.ToString(), new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 350, 250);
            e.Graphics.DrawString("Cognome: " + txtCognome.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 310);
            e.Graphics.DrawString("Nome: " + txtNome.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 350, 310);
            e.Graphics.DrawString("Indirizzo: " + txtIndirizzo.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 353);
            e.Graphics.DrawString("C.a.p. " + cap, new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 350, 353);
            e.Graphics.DrawString("Città: " + txtCitta.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 450, 353);
            e.Graphics.DrawString("Frazione: " + frazione, new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 396);
            e.Graphics.DrawString("Tel. " + txtTelefono.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 439);
            e.Graphics.DrawString("Cell. " +txtCellulare.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 175, 439);
            e.Graphics.DrawString("Email: " + txtMail.Text, new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 350, 439);
            e.Graphics.DrawString("Nato a: " + nascita, new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 482);
            e.Graphics.DrawString("Prov. (" + prov_nascita + ")", new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 350, 482);
            e.Graphics.DrawString("il " + dataNascita, new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 450, 482);
            e.Graphics.DrawString("Cod. Fisc. " + cf, new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 525);
            e.Graphics.DrawString("Attività svolta: BALLO SOCIALE", new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 568);
            e.Graphics.DrawString("FIRMA   ___________________________", new System.Drawing.Font("Calibri", 11,stile), Brushes.Black, x + 450, 606);
            e.Graphics.DrawString("INFORMATIVA EX ART. 13 D.LGS. 196 PER IL TRATTAMENTO DEI DATI PERSONALI", new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 70, 692);
            e.Graphics.DrawString("La informiamo che, secondo la normativa del D.lgs. n. 196 del 30 giugno 2003, il trattamento dei dati da Lei", new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 725);
            e.Graphics.DrawString("forniti avverrà per la sola comunicazione a Lei diretta di informazioni inerenti iniziative e spettacoli", new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 745);
            e.Graphics.DrawString("esclusivamente da parte dell'A.S.D. LISCIO CLUB.", new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 765);
            e.Graphics.DrawString("DICHIARAZIONE LIBERATORIA DI SANA COSTITUZIONE FISICA", new System.Drawing.Font("Calibri", 11,stile), Brushes.Black, x + 120, 840);
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