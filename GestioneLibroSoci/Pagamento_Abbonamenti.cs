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
    public partial class Pagamento_Abbonamenti : Form
    {
        int idTipologia;
        decimal quota;

        List<int> idSocio1, idSocio2;
        List<int> idAbbonamenti;

        public Pagamento_Abbonamenti()
        {
            InitializeComponent();
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
                this.Text = "Salda pagamenti " + dr["Nome"].ToString();
                quota = decimal.Parse(dr["Quota"].ToString());
            }

            dr.Close();

            cm.CommandText = "SELECT IDFattura,IDAbbonamento,IDSocio1,IDSocio2,Pagato,DataEmissione,Scadenza FROM Abbonamento WHERE (YEAR(DataEmissione)=YEAR(GETDATE()) AND IDTipologia="+idTipologia+") OR (IDTipologia="+idTipologia+" AND Pagato=0) ORDER BY(Pagato)";
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                idSocio1.Add(int.Parse(dr["IDSocio1"].ToString()));
                idSocio2.Add(int.Parse(dr["IDSocio2"].ToString()));
                pagato.Add(dr["Pagato"].ToString());
                emissione.Add(DateTime.Parse(dr["DataEmissione"].ToString()));
                scadenza.Add(DateTime.Parse(dr["Scadenza"].ToString()));
                idAbbonamenti.Add(int.Parse(dr["IDAbbonamento"].ToString()));
                int tmp;
                int.TryParse(dr["IDFattura"].ToString(), out tmp);
                idFatture.Add(tmp);
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

                cm.CommandText = "SELECT Data FROM Fattura WHERE IDFattura=" + idFatture[i];
                dr = cm.ExecuteReader();
                if (dr.Read())
                    dataPagamento.Add(DateTime.Parse(dr["Data"].ToString()).ToShortDateString());
                else
                    dataPagamento.Add("");
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
                riga.Add(dataPagamento[i]);

                elenco_abbonati.Rows.Add(riga.ToArray());
            }
        }

        public Pagamento_Abbonamenti(int id)
        {
            InitializeComponent();
            idTipologia = id;

            CaricaAbbonati();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            int Ntessera = idSocio1[elenco_abbonati.SelectedRows[0].Index];
            NuovaFattura form = new NuovaFattura(Ntessera,idAbbonamenti[elenco_abbonati.SelectedRows[0].Index],idTipologia);
            form.ShowDialog();
            CaricaAbbonati();
        }
    }
}
