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
    public partial class IngressiLive : Form
    {
        int idSerata;
        string nomeSerata;

        List<int> tessera;
        List<string> nome, cognome;
        List<DateTime> ora;

        public IngressiLive()
        {
            InitializeComponent();
            CaricaEvento();
        }

        public void CaricaEvento()
        {
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT IDSerata,Nome FROM SerataDanzante WHERE Giorno='" + DateTime.Now.ToShortDateString() + "'";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                idSerata = int.Parse(dr["IDSerata"].ToString());
                nomeSerata = dr["Nome"].ToString();

                lblEvento.Text = nomeSerata;
                timerAggiorna.Start();
                conn.Close();
                return;
            }

            conn.Close();


        }

        private void timerAggiorna_Tick(object sender, EventArgs e)
        {
            if (aggiorna.IsBusy == false)
                aggiorna.RunWorkerAsync();
        }

        private void aggiorna_DoWork(object sender, DoWorkEventArgs e)
        {
            tessera = new List<int>();
            cognome = new List<string>();
            nome = new List<string>();
            ora = new List<DateTime>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT Tessera,Nome,Cognome,Ora FROM Socio,Ingresso WHERE IDSerataDanzante=" + idSerata + " AND Socio.Codice=Ingresso.Codice";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                tessera.Add(int.Parse(dr["Tessera"].ToString()));
                nome.Add(dr["Nome"].ToString());
                cognome.Add(dr["Cognome"].ToString());
                ora.Add(DateTime.Parse(dr["Ora"].ToString()));
            }
            conn.Close();
        }

        private void aggiorna_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblIngressi.Text = tessera.Count.ToString().PadLeft(3, '0');
            listaIngressi.Items.Clear();

            for (int i = 0; i < tessera.Count; i++)
            {
                string tmp = cognome[i] + " " + nome[i] + " SOCIO N° " + tessera[i] + " entra alle " + ora[i].ToShortTimeString();
                listaIngressi.Items.Add(tmp);
            }
        }
    }
}
