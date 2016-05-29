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
    public partial class StampaIngressiEvento : Form
    {
        List<int> idSerata;
        List<string> nomeEvento;

        public StampaIngressiEvento()
        {
            InitializeComponent();
            Carica.RunWorkerAsync();
        }

        public void CaricaEvento()
        {
            idSerata = new List<int>();
            nomeEvento = new List<string>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT IDSerata,Nome FROM SerataDanzante WHERE Giorno<='" + DateTime.Now.ToShortDateString() + "'";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                idSerata.Add(int.Parse(dr["IDSerata"].ToString()));
                nomeEvento.Add(dr["Nome"].ToString());
            }
            conn.Close();
        }

        private void Carica_DoWork(object sender, DoWorkEventArgs e)
        {
            CaricaEvento();
        }

        private void Carica_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            for (int i = 0; i < idSerata.Count; i++)
            {
                listaEventi.Items.Add(nomeEvento[i]);
            }
        }
    }
}