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
    public partial class Prenotazione_tavolo : Form
    {
        public List<int> idEvento;
        public List<string> nomeEvento;
        public List<DateTime> dataEvento;

        public int Tavolo;

        public int tessera;

        public int indexRiga, indexEvento;

        public List<int> idNominativi;

        public Prenotazione_tavolo()
        {
            InitializeComponent();
            caricaEventi.RunWorkerAsync();
        }

        private void caricaEventi_DoWork(object sender, DoWorkEventArgs e)
        {
            idEvento = new List<int>();
            nomeEvento = new List<string>();
            dataEvento = new List<DateTime>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT IDSerata,Nome,Giorno FROM SerataDanzante WHERE Giorno>='" + DateTime.Now.ToShortDateString() + "' AND Prenotazione=1";
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

        private void caricaEventi_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            listaEventi.Items.Clear();
            foreach (string s in nomeEvento)
            {
                listaEventi.Items.Add(s);
            }

            if (listaEventi.Items.Count > 0)
                listaEventi.SelectedIndex = 0;
        }

        private void listaEventi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtGiorno.Text = dataEvento[listaEventi.SelectedIndex].ToShortDateString();
            CaricaPrenotazione();
        }

        public void CaricaPrenotazione()
        {
            idNominativi = new List<int>();
            txtGiorno.Text = dataEvento[listaEventi.SelectedIndex].ToShortDateString();
            VisualizzaDati.Rows.Clear();
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT * FROM Nominativo WHERE IDIngresso="+idEvento[listaEventi.SelectedIndex];
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                idNominativi.Add(int.Parse(dr["IDNominativo"].ToString()));
                List<string> riga = new List<string>();
                if (dr["Tessera"].ToString() == "0")
                    riga.Add("N.S.");
                else
                    riga.Add(dr["Tessera"].ToString());
                riga.Add(dr["Cognome"].ToString());
                riga.Add(dr["Nome"].ToString());
                riga.Add(dr["Persone"].ToString());
                if (dr["Pagato"].ToString() == "True")
                    riga.Add("SI");
                else
                    riga.Add("NO");
                riga.Add(dr["TavoloDa"].ToString());
                riga.Add(dr["NTavolo"].ToString());
                Tavolo = int.Parse(dr["NTavolo"].ToString());
                riga.Add(dr["Avanzo"].ToString());
                riga.Add(dr["Note"].ToString());
                VisualizzaDati.Rows.Add(riga.ToArray());
            }
            dr.Close();
            conn.Close();

            try
            {
                //listaEventi.SelectedIndex = indexEvento;
                VisualizzaDati.Rows[indexRiga].Selected = true;
            }
            catch { ;}
        }

        private void VisualizzaDati_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = VisualizzaDati.SelectedRows[0].Index;
            InserisciOspite form = new InserisciOspite(idNominativi[index], idEvento[listaEventi.SelectedIndex], int.Parse(VisualizzaDati.SelectedRows[0].Cells[6].Value.ToString()));
            form.ShowDialog();
        }

        private void checkSocio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSocio.Checked)
            {
                CercaSocio form = new CercaSocio();
                form.ShowDialog();
                if (form.tesseraSelezionata != 0)
                {
                    txtCognome.Text = form.cognomeSelezionato;
                    txtNome.Text = form.nomeSelezionato;
                    tessera = form.tesseraSelezionata;
                }
            }
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
             txtCognome.Text = txtCognome.Text.Replace("'", "''");
             txtNome.Text = txtNome.Text.Replace("'", "''");
            int pagato=0;
            if(checkPagato.Checked)
                pagato=1;
            else pagato=0;

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "INSERT INTO  Nominativo(Cognome,Nome,Persone,Pagato,Tessera,TavoloDa,NTavolo,Avanzo,Note,IDIngresso) VALUES('" + txtCognome.Text + "','" + txtNome.Text + "'," + txtPersone.Text + "," + pagato + "," + tessera + "," + txtTavoloDa.Text + "," + txtNumTavolo.Text + "," + txtAvanzo.Text + ",'" + txtNote.Text + "'," + idEvento[listaEventi.SelectedIndex] + ")";
            cm.Connection = conn;
            if (cm.ExecuteNonQuery() > 0)
                MessageBox.Show("Prenotazione inserita");
            conn.Close();
            tessera = 0;

            indexRiga = VisualizzaDati.Rows.Count;
            indexEvento = listaEventi.SelectedIndex;
            CaricaPrenotazione();
        }

        private void VisualizzaDati_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifica.Enabled = true;
            int index = VisualizzaDati.SelectedRows[0].Index;
            DataGridViewRow riga = VisualizzaDati.Rows[index];

            txtCognome.Text = riga.Cells[1].Value.ToString();
            txtNome.Text = riga.Cells[2].Value.ToString();
            txtPersone.Text = riga.Cells[3].Value.ToString();
            if (riga.Cells[4].Value.ToString() == "NO")
                checkPagato.Checked = false;
            else
                checkPagato.Checked = true;
            txtTavoloDa.Text = riga.Cells[5].Value.ToString();
            txtNumTavolo.Text = riga.Cells[6].Value.ToString();
            txtAvanzo.Text = riga.Cells[7].Value.ToString();
            txtNote.Text = riga.Cells[8].Value.ToString();

            indexRiga = index;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int pagato = 0;
            if (checkPagato.Checked)
                pagato = 1;
            else pagato = 0;

            int index = VisualizzaDati.SelectedRows[0].Index;

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "UPDATE  Nominativo SET Cognome='" + txtCognome.Text + "', Nome='" + txtNome.Text + "',Persone=" + txtPersone.Text + ",Pagato=" + pagato + ",TavoloDa=" + txtTavoloDa.Text + ",NTavolo=" + txtNumTavolo.Text + ",Avanzo=" + txtAvanzo.Text + ",Note='" + txtNote.Text + "' WHERE IDNominativo=" + idNominativi[index] + " AND IDIngresso=" + idEvento[listaEventi.SelectedIndex];
            cm.Connection = conn;
            if (cm.ExecuteNonQuery() > 0)
                MessageBox.Show("Prenotazione modificata");
            conn.Close();

            btnModifica.Enabled = false;
            CaricaPrenotazione();

        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            int index = VisualizzaDati.SelectedRows[0].Index;
            if (MessageBox.Show("Vuoi cancellare la prenotazione di " + VisualizzaDati.Rows[index].Cells[1].Value.ToString() + " " + VisualizzaDati.Rows[index].Cells[2].Value.ToString() + "?", "Conferma cancellazione", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                conn.Open();
                OdbcCommand cm = new OdbcCommand();
                cm.CommandText = "DELETE FROM  Nominativo WHERE IDnominativo=" + idNominativi[index] + " AND IDIngresso=" + idEvento[listaEventi.SelectedIndex];
                cm.Connection = conn;
                if (cm.ExecuteNonQuery() > 0)
                    MessageBox.Show("Prenotazione modificata");
                conn.Close();

                if (indexRiga > 0)
                    indexRiga = index - 1;
                else indexRiga = 0;
                CaricaPrenotazione();
            }
        }

        private void btnOspite_Click(object sender, EventArgs e)
        {
             int index = VisualizzaDati.SelectedRows[0].Index;
             InserisciOspite form = new InserisciOspite(idNominativi[index], idEvento[listaEventi.SelectedIndex],Tavolo);
             form.ShowDialog();
        }

        private void txtTavoloDa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int tmp = int.Parse(txtTavoloDa.Text) - int.Parse(txtPersone.Text);
                if (tmp >= 0)
                    txtAvanzo.Text = tmp.ToString();
            }
            catch { ;}
        }

        private void txtPersone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int tmp = int.Parse(txtTavoloDa.Text) - int.Parse(txtPersone.Text);
                if (tmp >= 0)
                    txtAvanzo.Text = tmp.ToString();
            }
            catch { ;}
        }

    }
}
