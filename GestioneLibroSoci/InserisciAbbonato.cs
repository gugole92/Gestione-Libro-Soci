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
    public partial class InserisciAbbonato : Form
    {
        int tesseraSocio1, tesseraSocio2;

        int valido;

        string componente;

        int Tipologia;

        public InserisciAbbonato()
        {
            InitializeComponent();
        }

        public InserisciAbbonato(int idTipologia)
        {
            Tipologia = idTipologia;

            InitializeComponent();

            MessageBox.Show("Inserisci il primo socio");
            CercaSocio form = new CercaSocio();
            form.ShowDialog();
            tesseraSocio1 = form.tesseraSelezionata;
            txtSocio1.Text = form.nomeSelezionato + " " + form.cognomeSelezionato;

            MessageBox.Show("Ora il secondo");
            form.ShowDialog();
            tesseraSocio2 = form.tesseraSelezionata;
            txtSocio2.Text = form.nomeSelezionato + " " + form.cognomeSelezionato;

            if (tesseraSocio1 == 0 || tesseraSocio2 == 0)
                this.Close();

            txtDataEmissione.Text = DateTime.Now.ToShortDateString();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT Nome,Valido,Componente FROM Tipologia WHERE IDTipologia="+idTipologia;
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                txtAbbonamento.Text = dr["Nome"].ToString();
                valido = int.Parse(dr["Valido"].ToString());
                componente = dr["Componente"].ToString();
            }
            conn.Close();

            CalcolaScadenza();
        }

        private void CalcolaScadenza()
        {
            switch (componente)
            {
                case "GIORNO/I":
                    DateTime scadenza = DateTime.Parse(txtDataEmissione.Text).AddDays(valido);
                    txtScadenza.Text = scadenza.ToShortDateString();
                    break;

                case "MESE/I":
                    scadenza = DateTime.Parse(txtDataEmissione.Text).AddMonths(valido);
                    txtScadenza.Text = scadenza.ToShortDateString();
                    break;

                case "ANNO/I":
                    scadenza = DateTime.Parse(txtDataEmissione.Text).AddYears(valido);
                    txtScadenza.Text = scadenza.ToShortDateString();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcolaScadenza();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            /* inserire controllo abbonamenti attivi / pagamenti in sospeso */
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "INSERT INTO Abbonamento(IDTipologia,IDSocio1,IDSocio2,Pagato,DataEmissione,Scadenza) VALUES (" + Tipologia + "," + tesseraSocio1 + "," + tesseraSocio2 + ",0,'" + txtDataEmissione.Text + "','" + txtScadenza.Text + "')";
            cm.Connection = conn;
            if (cm.ExecuteNonQuery() > 0)
                MessageBox.Show("Abbonamento inserito correttamente.");
            conn.Close();
            this.Close();
        }
    }
}
