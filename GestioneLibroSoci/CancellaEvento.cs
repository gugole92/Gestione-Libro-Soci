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
    public partial class CancellaEvento : Form
    {
        public List<int> idEvento;
        public List<string> nomeEvento;
        public List<DateTime> dataEvento;

        public CancellaEvento()
        {
            InitializeComponent();
            CaricaEventi.RunWorkerAsync();
        }

        private void CaricaEventi_DoWork(object sender, DoWorkEventArgs e)
        {
            idEvento = new List<int>();
            nomeEvento = new List<string>();
            dataEvento = new List<DateTime>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT IDSerata,Nome,Giorno FROM SerataDanzante WHERE Giorno>='" + DateTime.Now.ToShortDateString()+"'";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                idEvento.Add(int.Parse(dr["IDSerata"].ToString()));
                nomeEvento.Add(dr["Nome"].ToString());
                dataEvento.Add(DateTime.Parse(dr["Giorno"].ToString()));
            }
            dr.Close();
            conn.Close();
        }

        private void CaricaEventi_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            listaEventi.Items.Clear();
            foreach (string s in nomeEvento)
            {
                listaEventi.Items.Add(s);
            }

            if (listaEventi.Items.Count > 0)
                listaEventi.SelectedIndex = 0;
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confermi la cancellazione dell'evento del " + dataEvento[listaEventi.SelectedIndex].ToShortDateString() + "?", "Conferma cancellazione", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                conn.Open();
                OdbcCommand cm = new OdbcCommand();
                cm.CommandText = "DELETE FROM SerataDanzante WHERE IDSerata="+idEvento[listaEventi.SelectedIndex];
                cm.Connection = conn;
                if (cm.ExecuteNonQuery() > 0)
                    MessageBox.Show("Evento cancellato");
                conn.Close();

                CaricaEventi.RunWorkerAsync();
            }
        }

        private void listaEventi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGiorno.Text = dataEvento[listaEventi.SelectedIndex].ToShortDateString();
        }
    }
}
