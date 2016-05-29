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
    public partial class Modifica_abbonamento : Form
    {
        List<string> nomeTipologia;
        List<int> numLezioni;
        List<int> validi;
        List<string> componente;
        List<double> quota;
        List<int> idTipologia;

        public Modifica_abbonamento()
        {
            InitializeComponent();
            nomeTipologia = new List<string>();
            idTipologia = new List<int>();
            numLezioni = new List<int>();
            validi = new List<int>();
            componente = new List<string>();
            quota = new List<double>();

            CaricaTipologie();
            if (idTipologia.Count > 0)
                listaTipologie.SelectedIndex = 0;
        }

        public void CaricaTipologie()
        {
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT * FROM Tipologia";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                idTipologia.Add(int.Parse(dr["IDTipologia"].ToString()));
                nomeTipologia.Add(dr["Nome"].ToString());
                numLezioni.Add(int.Parse(dr["NumeroLezioni"].ToString()));
                validi.Add(int.Parse(dr["Valido"].ToString()));
                componente.Add(dr["Componente"].ToString());
                quota.Add(double.Parse(dr["Quota"].ToString()));
            }
            conn.Close();

            foreach (string s in nomeTipologia)
                listaTipologie.Items.Add(s);
        }

        private void listaTipologie_SelectedIndexChanged(object sender, EventArgs e)
        {
            lezioni.Enabled = true;
            valido.Enabled = true;
            componenti.Enabled = true;
            txtQuota.Enabled = true;
            btnConferma.Enabled = true;

            lezioni.Value = numLezioni[listaTipologie.SelectedIndex];
            valido.Value = validi[listaTipologie.SelectedIndex];
            switch (componente[listaTipologie.SelectedIndex])
            {
                case "GIORNO/I": componenti.SelectedIndex = 0; break;
                case "MESE/I": componenti.SelectedIndex = 1; break;
                case "ANNO/I": componenti.SelectedIndex = 2; break;
            }
            txtQuota.Text = quota[listaTipologie.SelectedIndex].ToString();
            if (!txtQuota.Text.Contains(','))
                txtQuota.Text += ",00";
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "UPDATE Tipologia SET NumeroLezioni=" + lezioni.Value + ",Valido=" + valido.Value + ",Componente='" + componenti.Text + "',Quota=" + txtQuota.Text.Replace(',', '.') + " WHERE IDTipologia=" + idTipologia[listaTipologie.SelectedIndex];
            cm.Connection = conn;
            if (cm.ExecuteNonQuery() > 0)
                MessageBox.Show("Abbonamento modificato nel database. Le modifiche non hanno effetto sugli abbonamenti già attivi");
            conn.Close();
            this.Close();
        }
    }
}
