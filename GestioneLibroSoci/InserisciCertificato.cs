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
    public partial class InserisciCertificato : Form
    {
        public int Tessera;

        public DateTime scadenzaCertificato;

        public InserisciCertificato()
        {
            InitializeComponent();
            CercaSocio form = new CercaSocio();
            form.ShowDialog();
            Tessera = form.tesseraSelezionata;
            if (Tessera != 0)
                CaricaSocio();

            
        }

        public void CaricaSocio()
        {
            txtTessera.Text += Tessera.ToString();
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT * FROM Socio WHERE ID_Socio=" + Tessera;
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                txtCognome.Text = dr["Cognome"].ToString();
                txtNome.Text = dr["Nome"].ToString();
                txtVia.Text = dr["Indirizzo"].ToString();
                txtCitta.Text = dr["Comune"].ToString();
                txtCellulare.Text = dr["Cellulare"].ToString();
                txtTelefono.Text = dr["Telefono"].ToString();
                txtMail.Text = dr["Email"].ToString();
            }
            dr.Close();

            cm.CommandText = "SELECT MAX(Data_Scadenza) FROM Certificato WHERE ID_Socio=" + Tessera;
            dr = cm.ExecuteReader();
            dr.Read();

            DateTime.TryParse(dr[0].ToString(), out scadenzaCertificato);

            if (scadenzaCertificato.Equals(DateTime.MinValue))
            {
                lblData.Text = "SCADENZA CERTIFICATO NON IMPOSTATA";
                dr.Close();
                cmbTipologia.SelectedIndex = 0;
            }
            else
            {
                if (scadenzaCertificato < DateTime.Now)
                {
                    lblData.Text = "SCADUTO DAL " + scadenzaCertificato.ToShortDateString();
                    cmbTipologia.SelectedIndex = 0;
                }
                else
                {
                    dr.Close();
                    cm.CommandText = "SELECT Agonistico FROM Certificato WHERE ID_Socio=" + Tessera + " AND Data_Scadenza='" + scadenzaCertificato.ToShortDateString() + "'";
                    dr = cm.ExecuteReader();
                    dr.Read();
                    bool index = bool.Parse(dr["Agonistico"].ToString());
                    dr.Close();
                    if (index)
                        cmbTipologia.SelectedIndex = 1;
                    else
                        cmbTipologia.SelectedIndex = 0;
                    lblData.Text = scadenzaCertificato.ToShortDateString();
                }
            }
            conn.Close();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "INSERT INTO Certificato (Agonistico,Data_Scadenza,ID_Socio) VALUES (" + cmbTipologia.SelectedIndex + ",'" + txtData.Text + "'," + Tessera + ")";
            cm.Connection = conn;
            if (cm.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Certificato inserito.");

            }
            else
                MessageBox.Show("Errore durante l'inserimento!");
            conn.Close();

            if (MessageBox.Show("Vuoi inserire un altro certificato?", "Inserisci certificato", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                txtData.Clear();
                txtTessera.Text = "Tessera n.";
                CercaSocio form = new CercaSocio();
                form.ShowDialog();
                Tessera = form.tesseraSelezionata;
                if (Tessera != 0)
                    CaricaSocio();
            }
            else
                this.Close();
            
        }
    }
}
