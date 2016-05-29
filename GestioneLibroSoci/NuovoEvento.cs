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
    public partial class NuovoEvento : Form
    {
        public NuovoEvento()
        {
            InitializeComponent();
            CaricaEventi();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            int prenotazione = 0;
            if (chkPrenotazione.Checked)
                prenotazione = 1;
            else
                prenotazione = 0;

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.Connection = conn;
            cm.CommandText = "INSERT INTO SerataDanzante(Nome,Giorno,Prenotazione) VALUES('" + txtNome.Text + "','" + dataEvento.SelectionStart.ToShortDateString() + "'," +prenotazione + ")";
            cm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Evento inserito nel database");
            CaricaEventi();
        }

        private void CaricaEventi()
        {
            listaEventi.Rows.Clear();
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.Connection = conn;
            cm.CommandText = "SELECT Nome,Giorno,Prenotazione FROM SerataDanzante WHERE Giorno>='" + DateTime.Now.ToShortDateString() + "'";

            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                List<string> riga = new List<string>();
                riga.Add(dr["Nome"].ToString());
                riga.Add(DateTime.Parse(dr["Giorno"].ToString()).ToShortDateString());
                riga.Add(bool.Parse(dr["Prenotazione"].ToString()).ToString());
                listaEventi.Rows.Add(riga.ToArray());
            }
            dr.Close();
            conn.Close();
        }
    }
}
