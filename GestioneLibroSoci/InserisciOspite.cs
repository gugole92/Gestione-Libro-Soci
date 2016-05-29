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
    public partial class InserisciOspite : Form
    {
        public int nominativo, evento;
        public List<int> idOspiti;
        public int tessera;

        public int indexRiga;

        public InserisciOspite()
        {
            InitializeComponent();
        }

        public InserisciOspite(int IDNominativo, int IDEvento,int tavolo)
        {
            InitializeComponent();
            this.Text = "Ospiti al tavolo " + tavolo;
            nominativo = IDNominativo;
            evento = IDEvento;
            CaricaOspiti();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            txtNominativo.Text = txtNominativo.Text.Replace("'", "''");
            int pagato = 0;
            if (checkPagato.Checked)
                pagato = 1;
            else pagato = 0;

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "INSERT INTO Ospite(Nome,IDNominativo,IDIngresso,Note,Tessera,Pagato) VALUES('" + txtNominativo.Text + "'," + nominativo + "," + evento + ",'" + txtNote.Text + "'," + tessera + "," + pagato + ")";
            cm.Connection = conn;
            if (cm.ExecuteNonQuery() > 0)
                MessageBox.Show("Ospite inserito");
            conn.Close();
            txtNominativo.Clear();
            txtNote.Clear();
            tessera = 0;
            CaricaOspiti();
        }

        public void CaricaOspiti()
        {
            VisualizzaDati.Rows.Clear();
            idOspiti = new List<int>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT * FROM Ospite WHERE IDIngresso="+evento+" AND IDNominativo="+nominativo;
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                idOspiti.Add(int.Parse(dr["IDOspite"].ToString()));
                List<string> riga = new List<string>();
                if (dr["Tessera"].ToString() == "0")
                    riga.Add("N.S.");
                else
                    riga.Add(dr["Tessera"].ToString());
                riga.Add(dr["Nome"].ToString());
                riga.Add(dr["Note"].ToString());
                if (dr["Pagato"].ToString() == "True")
                    riga.Add("SI");
                else
                    riga.Add("NO");
                VisualizzaDati.Rows.Add(riga.ToArray());
            }

            indexRiga = VisualizzaDati.Rows.Count;
            conn.Close();
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            int index = VisualizzaDati.SelectedRows[0].Index;
            if (MessageBox.Show("Vuoi cancellare l'ospite " + VisualizzaDati.Rows[index].Cells[1].Value.ToString(), "Conferma cancellazione", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                conn.Open();
                OdbcCommand cm = new OdbcCommand();
                cm.CommandText = "DELETE FROM Ospite WHERE IDOspite=" + idOspiti[index];
                cm.Connection = conn;
                if (cm.ExecuteNonQuery() > 0)
                    MessageBox.Show("Ospite cancellato");
                conn.Close();
                CaricaOspiti();
            }
        }

        private void checkSocio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSocio.Checked)
            {
                CercaSocio form = new CercaSocio();
                form.ShowDialog();
                if (form.tesseraSelezionata != 0)
                {
                    txtNominativo.Text = form.cognomeSelezionato + " " + form.nomeSelezionato;
                    tessera = form.tesseraSelezionata;
                }
            }
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
            cm.CommandText = "UPDATE  Ospite SET Nome='" + txtNominativo.Text + "', Note='" + txtNote.Text + "',Pagato=" + pagato + " WHERE IDOspite=" + idOspiti[index];
            cm.Connection = conn;
            if (cm.ExecuteNonQuery() > 0)
                MessageBox.Show("Prenotazione modificata");
            conn.Close();

            btnModifica.Enabled = false;
            CaricaOspiti();
        }

        private void VisualizzaDati_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifica.Enabled = true;

            int index = VisualizzaDati.SelectedRows[0].Index;
            DataGridViewRow riga = VisualizzaDati.Rows[index];

            txtNominativo.Text = riga.Cells[1].Value.ToString();
            txtNote.Text = riga.Cells[2].Value.ToString();
            if (riga.Cells[3].Value.ToString() == "NO")
                checkPagato.Checked = false;
            else
                checkPagato.Checked = true;
        }
    }
}
