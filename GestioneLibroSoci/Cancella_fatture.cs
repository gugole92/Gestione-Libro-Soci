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
    public partial class Cancella_fatture : Form
    {
        public List<int> ListaIDFattura;
        public List<string> Listanominativi;
        public List<string> ListaCF;
        public List<string> ListaDescrizione;
        public List<decimal> ListaImporto;
        public List<DateTime> ListaData;
        public List<int> ListaAliquota;
        public List<int> ListaProgressivo;
        public List<string> ListaIVA;

        public int indexRiga;

        public Cancella_fatture()
        {
            InitializeComponent();
            CaricaAnni();
        }

        public void CaricaAnni()
        {
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT DISTINCT YEAR(Data) FROM Fattura ORDER BY YEAR(Data) DESC";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbAnno.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();

            if (cmbAnno.Items.Count > 0)
                cmbAnno.SelectedIndex = 0;
        }

        private void cmbAnno_SelectedIndexChanged(object sender, EventArgs e)
        {

            CaricaFatture();
        }

        private void CaricaFatture()
        {
            ListaIDFattura = new List<int>();
            Listanominativi = new List<string>();
            ListaCF = new List<string>();
            ListaIVA = new List<string>();
            ListaDescrizione = new List<string>();
            ListaImporto = new List<decimal>();
            ListaAliquota = new List<int>();
            ListaData = new List<DateTime>();
            ListaProgressivo = new List<int>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT * FROM Fattura WHERE YEAR(Data)=" + cmbAnno.Text;
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                ListaIDFattura.Add(int.Parse(dr["IDFattura"].ToString()));
                Listanominativi.Add(dr["Nominativo"].ToString());
                ListaCF.Add(dr["CF"].ToString());
                ListaIVA.Add(dr["IVA"].ToString());
                ListaDescrizione.Add(dr["Descrizione"].ToString());
                ListaImporto.Add(decimal.Parse(dr["Importo"].ToString()));
                ListaAliquota.Add(int.Parse(dr["Aliquota"].ToString()));
                ListaData.Add(DateTime.Parse(dr["Data"].ToString()));
                ListaProgressivo.Add(int.Parse(dr["Progressivo"].ToString()));
            }
            dr.Close();
            conn.Close();

            VisualizzaDati.Rows.Clear();

            for (int i = 0; i < ListaIDFattura.Count(); i++)
            {
                List<string> riga = new List<string>();
                riga.Add(Listanominativi[i]);
                riga.Add(ListaCF[i]);
                riga.Add(ListaIVA[i]);
                riga.Add(ListaDescrizione[i]);
                riga.Add(ListaImporto[i].ToString());
                riga.Add(ListaAliquota[i].ToString());
                riga.Add(ListaData[i].ToShortDateString());
                riga.Add(ListaProgressivo[i].ToString());
                VisualizzaDati.Rows.Add(riga.ToArray());
            }

            if (VisualizzaDati.Rows.Count > 0)
                VisualizzaDati.Rows[indexRiga].Selected = true;
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            if (VisualizzaDati.SelectedRows[0].Index >= 0)
            {
                indexRiga = VisualizzaDati.SelectedRows[0].Index;
                int progressivo = ListaProgressivo[indexRiga];
                if (MessageBox.Show("Vuoi cancellare la fattura N° " + progressivo + "?", "Conferma cancellazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                    conn.Open();
                    OdbcCommand cm = new OdbcCommand();
                    cm.Connection = conn;

                    cm.CommandText = "DELETE FROM Fattura WHERE IDFattura=" + ListaIDFattura[indexRiga];
                    if (cm.ExecuteNonQuery() > 0)
                        MessageBox.Show("Fattura cancellata");
                    CaricaFatture();
                }
            }
        }

    }
}
