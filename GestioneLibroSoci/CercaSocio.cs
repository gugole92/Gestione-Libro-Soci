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
    public partial class CercaSocio : Form
    {
        public List<int> tessere;
        public List<string> cognomi;
        public List<string> nomi;
        public List<string> indirizzi;
        public List<string> comuni;

        public int tesseraSelezionata;
        public string nomeSelezionato, cognomeSelezionato;

        public CercaSocio()
        {
            InitializeComponent();
            CaricaSoci.RunWorkerAsync();
        }

        private void CaricaSoci_DoWork(object sender, DoWorkEventArgs e)
        {
            tessere = new List<int>();
            cognomi = new List<string>();
            nomi = new List<string>();
            indirizzi = new List<string>();
            comuni = new List<string>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT Tessera,Cognome,Nome,Indirizzo,Comune FROM Socio";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                tessere.Add(int.Parse(dr["Tessera"].ToString()));
                cognomi.Add(dr["Cognome"].ToString());
                nomi.Add(dr["Nome"].ToString());
                indirizzi.Add(dr["Indirizzo"].ToString());
                comuni.Add(dr["Comune"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void CaricaSoci_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            info.Text = "Caricamento completato.";
        }

        private void txtCognome_TextChanged(object sender, EventArgs e)
        {
            lista_Soci.Rows.Clear();
            for (int i = 0; i < tessere.Count; i++)
            {
                if (cognomi[i].Contains(txtCognome.Text))
                {
                    List<string> riga = new List<string>();
                    riga.Add(tessere[i].ToString());
                    riga.Add(cognomi[i].ToString());
                    riga.Add(nomi[i].ToString());
                    riga.Add(indirizzi[i].ToString());
                    riga.Add(comuni[i].ToString());
                    lista_Soci.Rows.Add(riga.ToArray());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tesseraSelezionata = int.Parse(lista_Soci.SelectedRows[0].Cells[0].Value.ToString());
            nomeSelezionato = lista_Soci.SelectedRows[0].Cells[2].Value.ToString();
            cognomeSelezionato = lista_Soci.SelectedRows[0].Cells[1].Value.ToString();
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lista_Soci.Rows.Clear();
            for (int i = 0; i < tessere.Count; i++)
            {
                if (nomi[i].Contains(txtNome.Text))
                {
                    List<string> riga = new List<string>();
                    riga.Add(tessere[i].ToString());
                    riga.Add(cognomi[i].ToString());
                    riga.Add(nomi[i].ToString());
                    riga.Add(indirizzi[i].ToString());
                    riga.Add(comuni[i].ToString());
                    lista_Soci.Rows.Add(riga.ToArray());
                }
            }
        }

        private void txtCodice_TextChanged(object sender, EventArgs e)
        {
            lista_Soci.Rows.Clear();
            for (int i = 0; i < tessere.Count; i++)
            {
                try
                {
                    if (tessere[i] == int.Parse(txtCodice.Text))
                    {
                        List<string> riga = new List<string>();
                        riga.Add(tessere[i].ToString());
                        riga.Add(cognomi[i].ToString());
                        riga.Add(nomi[i].ToString());
                        riga.Add(indirizzi[i].ToString());
                        riga.Add(comuni[i].ToString());
                        lista_Soci.Rows.Add(riga.ToArray());
                    }
                }
                catch { ;}
            }
        }
    }
}
