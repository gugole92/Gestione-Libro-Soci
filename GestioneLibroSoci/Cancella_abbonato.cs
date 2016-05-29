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

namespace GestioneLibroSoci
{
    public partial class Cancella_abbonato : Form
    {
        List<int> idSocio1, idSocio2;
        List<int> idAbbonamenti;

        int tesseraSocio1, tesseraSocio2;

        int idTipologia;

        public Cancella_abbonato()
        {
            InitializeComponent();
        }

        public Cancella_abbonato(int tipologia)
        {
            InitializeComponent();
            idTipologia = tipologia;
            CaricaAbbonati();
        }

        public void CaricaAbbonati()
        {

            List<string> pagato;
            List<DateTime> emissione, scadenza;
            List<string> cognomiSoci = new List<string>();
            List<string> dataPagamento = new List<string>();
            List<int> idFatture = new List<int>();

            idSocio1 = new List<int>();
            idSocio2 = new List<int>();
            pagato = new List<string>();
            emissione = new List<DateTime>();
            scadenza = new List<DateTime>();
            idAbbonamenti = new List<int>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT Nome,Quota FROM Tipologia WHERE IDTipologia=" + idTipologia;
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                this.Text = "Annulla abbonamento " + dr["Nome"].ToString();
            }

            dr.Close();

            cm.CommandText = "SELECT IDAbbonamento,IDSocio1,IDSocio2,Pagato,DataEmissione,Scadenza FROM Abbonamento WHERE (Scadenza>=GETDATE() AND IDTipologia=" + idTipologia + ") OR (IDTipologia=" + idTipologia + " AND Pagato=0) ORDER BY(Pagato)";
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                idSocio1.Add(int.Parse(dr["IDSocio1"].ToString()));
                idSocio2.Add(int.Parse(dr["IDSocio2"].ToString()));
                pagato.Add(dr["Pagato"].ToString());
                emissione.Add(DateTime.Parse(dr["DataEmissione"].ToString()));
                scadenza.Add(DateTime.Parse(dr["Scadenza"].ToString()));
                idAbbonamenti.Add(int.Parse(dr["IDAbbonamento"].ToString()));
            }
            dr.Close();

            for (int i = 0; i < idSocio1.Count; i++)
            {
                string tmp = "";
                cm.CommandText = "SELECT Cognome FROM Socio WHERE Tessera=" + idSocio1[i];
                dr = cm.ExecuteReader();
                dr.Read();
                tmp = dr["Cognome"].ToString();
                dr.Close();

                cm.CommandText = "SELECT Cognome From Socio WHERE Tessera=" + idSocio2[i];
                dr = cm.ExecuteReader();
                dr.Read();
                tmp += " - " + dr["Cognome"].ToString();
                dr.Close();

                cognomiSoci.Add(tmp);

                dr.Close();

            }

            conn.Close();

            elenco_abbonati.Rows.Clear();

            for (int i = 0; i < idSocio1.Count; i++)
            {
                List<string> riga = new List<string>();
                riga.Add(cognomiSoci[i]);
                if (pagato[i].Equals("True"))
                    riga.Add("PAGATO");
                else
                    riga.Add("NON PAGATO");

                riga.Add(emissione[i].ToShortDateString());
                riga.Add(scadenza[i].ToShortDateString());

                elenco_abbonati.Rows.Add(riga.ToArray());
            }
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.Connection = conn;

            if (elenco_abbonati.SelectedRows[0].Cells[1].Value.Equals("NON PAGATO"))
            {
                if (MessageBox.Show("Sei sicuro di annullare l'abbonamento di " + elenco_abbonati.SelectedRows[0].Cells[0].Value.ToString() + "? Sono presenti pagamenti non saldati!", "Conferma cancellazione", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    cm.CommandText = "DELETE FROM Abbonamento WHERE IDAbbonamento=" + idAbbonamenti[elenco_abbonati.SelectedRows[0].Index];
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Abbonamento annullato");
                    CaricaAbbonati();
                }
            }

            else
            {
                if (MessageBox.Show("Sei sicuro di annullare l'abbonamento di " + elenco_abbonati.SelectedRows[0].Cells[0].Value + "? La scadenza è prevista al " + elenco_abbonati.SelectedRows[0].Cells[3].Value, "Conferma cancellazione", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    cm.CommandText = "DELETE FROM Abbonamento WHERE IDAbbonamento=" + idAbbonamenti[elenco_abbonati.SelectedRows[0].Index];
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Abbonamento annullato");
                    CaricaAbbonati();
                }
            }

            conn.Close();
        }

    }
}
