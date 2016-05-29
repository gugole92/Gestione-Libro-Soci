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
    public partial class Modifica_nominativi : Form
    {
        public string nominativo, indirizzo, codiceFiscale, partitaIVA;

        public int recordAggiornati;

        public Modifica_nominativi()
        {
            InitializeComponent();

            CercaNominativo form = new CercaNominativo();
            form.ShowDialog();
            nominativo = form.nominativo;
            indirizzo = form.indirizzo;
            codiceFiscale = form.codiceFiscale;
            partitaIVA = form.partitaIVA;

            txtNominativo.Text = nominativo;
            txtIndirizzo.Text = indirizzo;
            txtCF.Text = codiceFiscale;
            txtpIVA.Text = partitaIVA;

            if (nominativo == null)
                this.Close();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Aggiornare nel database tutte le occorrenze di " + nominativo + " CF: " + codiceFiscale + " P. IVA: " + partitaIVA + " ?", "Conferma aggiornamento", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                info.Text = "Aggiornamento in corso...";
                progressivo.Style = ProgressBarStyle.Marquee;
                AggiornaNominativi.RunWorkerAsync();
            }
        }

        private void AggiornaNominativi_DoWork(object sender, DoWorkEventArgs e)
        {
            
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            OdbcCommand cm = new OdbcCommand();
            cm.Connection = conn;
            cm.CommandText = "UPDATE Fattura SET Nominativo='" + txtNominativo.Text + "', Indirizzo='" + txtIndirizzo.Text + "',CF='" + txtCF.Text + "',IVA='" + txtpIVA.Text + "' WHERE CF='" + codiceFiscale + "' AND IVA='" + partitaIVA + "'";
            conn.Open();
            recordAggiornati = cm.ExecuteNonQuery();
            conn.Close();
        }

        private void AggiornaNominativi_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Sono state aggiornate " + recordAggiornati + " occorrenze nel database");
            info.Text = "Aggiornamento completato.";
            progressivo.Style = ProgressBarStyle.Blocks;
            progressivo.Value = 100;
            this.Close();
        }
    }
}
