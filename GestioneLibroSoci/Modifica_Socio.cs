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
using System.Data.OleDb;
using CodiceFiscale;
using System.Collections;

namespace GestioneLibroSoci
{
    public partial class Modifica_Socio : Form
    {
        public ClsCodiceFiscale calcoloCF;
        ArrayList vetStrErrori;

        public int Tessera;

        public Modifica_Socio()
        {
            InitializeComponent();

            calcoloCF = new ClsCodiceFiscale();

            CercaSocio form = new CercaSocio();
            form.ShowDialog();
            Tessera = form.tesseraSelezionata;
            if (Tessera != 0)
                CaricaSocio();
        }

        public void CaricaSocio()
        {
            txtTessera.Text = "Tessera n. " + Tessera.ToString();
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT * FROM Socio WHERE Tessera="+Tessera;
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                txtCodice.Text = dr["Codice"].ToString();
                txtCognome.Text = dr["Cognome"].ToString();
                txtNome.Text = dr["Nome"].ToString();
                txtSesso.Text = dr["Sesso"].ToString();
                txtLuogoNascita.Text = dr["Nascita"].ToString();
                txtProvNascita.Text = dr["Provincia_Nascita"].ToString();
                txtDataNascita.Text = DateTime.Parse(dr["Data_Nascita"].ToString()).ToShortDateString();
                txtCF.Text = dr["CF"].ToString();
                txtVia.Text = dr["Indirizzo"].ToString();
                txtFrazione.Text = dr["Frazione"].ToString();
                txtCap.Text = dr["CAP"].ToString();
                txtCitta.Text = dr["Comune"].ToString();
                txtProvResidenza.Text = dr["Provincia_Residenza"].ToString();
                txtCellulare.Text = dr["Cellulare"].ToString();
                txtTelefono.Text = dr["Telefono"].ToString();
                txtMail.Text = dr["Email"].ToString();
            }
            dr.Close();
            conn.Close();

            txtTessera.Select();
            txtTessera.Focus();
        }

        private void txtCitta_Leave(object sender, EventArgs e)
        {
            string strStringaConnessione = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Environment.CurrentDirectory + "\\Comuni.mdb";
            OleDbConnection connessioneDB = new OleDbConnection(strStringaConnessione);
            OleDbCommand commandDB = new OleDbCommand("select Provincia,CAP from comuni WHERE Comune='" + txtCitta.Text.Replace("'","''") + "'", connessioneDB);
            connessioneDB.Open();

            OleDbDataReader dataReaderDB = commandDB.ExecuteReader();
            if (dataReaderDB.Read())
            {
                txtProvResidenza.Text = dataReaderDB.GetString(dataReaderDB.GetOrdinal("Provincia"));
                txtCap.Text = dataReaderDB.GetString(dataReaderDB.GetOrdinal("CAP"));
            }

            dataReaderDB.Close();
            connessioneDB.Close();
        }

        private void txtCitta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLuogoNascita_Leave(object sender, EventArgs e)
        {
            string strStringaConnessione = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Environment.CurrentDirectory + "\\Comuni.mdb";
            OleDbConnection connessioneDB = new OleDbConnection(strStringaConnessione);
            OleDbCommand commandDB = new OleDbCommand("select Provincia from comuni WHERE Comune='" + txtLuogoNascita.Text.Replace("'", "''") + "'", connessioneDB);
            connessioneDB.Open();

            OleDbDataReader dataReaderDB = commandDB.ExecuteReader();
            if (dataReaderDB.Read())
            {
                txtProvNascita.Text = dataReaderDB.GetString(dataReaderDB.GetOrdinal("Provincia"));
            }

            dataReaderDB.Close();
            connessioneDB.Close();
        }

        private void txtLuogoNascita_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSesso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSesso_Leave(object sender, EventArgs e)
        {
            if (txtCF.Text == "")
            {
                vetStrErrori = new ArrayList();
                try
                {
                    string codiceFiscale = calcoloCF.CalcolaCF(txtNome.Text, txtCognome.Text, char.Parse(txtSesso.Text), txtDataNascita.Text, txtLuogoNascita.Text, txtProvNascita.Text, vetStrErrori);
                    txtCF.Text = codiceFiscale;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Attenzione tutti i dati salvati verranno sovrascritti, confermi il salvataggio?", "Conferma salva", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
             
                OdbcCommand cm = new OdbcCommand();
                cm.CommandText = "UPDATE Socio SET Codice='" + txtCodice.Text + "',Cognome='" + txtCognome.Text.Replace("'", "''") + "',Nome='" + txtNome.Text.Replace("'", "''") + "',Sesso='" + txtSesso.Text + "',Nascita='" + txtLuogoNascita.Text.Replace("'", "''") + "',Provincia_Nascita='" + txtProvNascita.Text + "',Data_Nascita='" + txtDataNascita.Text + "',CF='" + txtCF.Text + "',Indirizzo='" + txtVia.Text.Replace("'", "''") + "',Frazione='" + txtFrazione.Text.Replace("'", "''") + "',CAP='" + txtCap.Text + "',Comune='" + txtCitta.Text.Replace("'", "''") + "',Provincia_Residenza='" + txtProvResidenza.Text + "',Cellulare='" + txtCellulare.Text + "',Telefono='" + txtTelefono.Text + "',Email='" + txtMail.Text + "' WHERE Tessera=" + Tessera;
                //cm.Parameters.AddWithValue("@codice", txtCodice.Text);
                //cm.Parameters.AddWithValue("@cognome", txtCognome.Text);
                //cm.Parameters.AddWithValue("@nome", txtNome.Text);
                //cm.Parameters.AddWithValue("@sesso", txtSesso.Text);
                //cm.Parameters.AddWithValue("@nascita", txtLuogoNascita.Text);
                //cm.Parameters.AddWithValue("@provNascita", txtProvNascita.Text);
                //cm.Parameters.AddWithValue("@cf", txtCF.Text);
                //cm.Parameters.AddWithValue("@indirizzo", txtVia.Text);
                //cm.Parameters.AddWithValue("@frazione", txtFrazione.Text);
                //cm.Parameters.AddWithValue("@cap", txtCap.Text);
                //cm.Parameters.AddWithValue("@comune", txtCitta.Text);
                //cm.Parameters.AddWithValue("@provResidenza", txtProvResidenza.Text);
                //cm.Parameters.AddWithValue("@cellulare", txtCellulare.Text);
                //cm.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                //cm.Parameters.AddWithValue("@email", txtMail.Text);
                cm.Connection = conn;
                conn.Open();
                if (cm.ExecuteNonQuery() > 0)
                {
                    if (MessageBox.Show("Socio modificato nel database. Vuoi modificarne un altro?", "Conferma modifica", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        CercaSocio form = new CercaSocio();
                        form.ShowDialog();
                        Tessera = form.tesseraSelezionata;
                        if (Tessera != 0)
                            CaricaSocio();
                    }
                    else this.Close();
                }

                conn.Close();
            }
        }
    }
}
