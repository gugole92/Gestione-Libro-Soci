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
    public partial class CercaNominativo : Form
    {
        private List<string> nominativi, indirizzi, cf, iva;

        public string nominativo,indirizzo,partitaIVA,codiceFiscale;

        public CercaNominativo()
        {
            nominativi = new List<string>();
            indirizzi = new List<string>();
            cf = new List<string>();
            iva = new List<string>();
            InitializeComponent();
            caricaNominativi.RunWorkerAsync();
        }

        private void caricaNominativi_DoWork(object sender, DoWorkEventArgs e)
        {
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT DISTINCT Nominativo,CF,IVA,Indirizzo FROM Fattura WHERE IDSocio IS NULL ORDER BY(Nominativo)";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                nominativi.Add(dr["Nominativo"].ToString());
                indirizzi.Add(dr["Indirizzo"].ToString());
                cf.Add(dr["CF"].ToString());
                iva.Add(dr["IVA"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void caricaNominativi_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (string s in nominativi)
                txtNominativo.Items.Add(s);

            if (txtNominativo.Items.Count > 0)
                txtNominativo.SelectedIndex = 0;
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            nominativo = txtNominativo.Text;
            indirizzo = txtIndirizzo.Text;
            codiceFiscale = txtCF.Text;
            partitaIVA = txtpIVA.Text;
            this.Close();
        }

        private void txtNominativo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIndirizzo.Text = indirizzi[txtNominativo.SelectedIndex];
            txtCF.Text = cf[txtNominativo.SelectedIndex];
            txtpIVA.Text = iva[txtNominativo.SelectedIndex];
        }
    }
}
