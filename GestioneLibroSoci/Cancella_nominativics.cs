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
    public partial class Cancella_nominativics : Form
    {
        public string nominativo, indirizzo, codiceFiscale, partitaIVA;

        public int recordAggiornati;

        public Cancella_nominativics()
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
            if (MessageBox.Show("Cancellare dal database tutte le occorrenze di " + nominativo + " CF: " + codiceFiscale + " P. IVA: " + partitaIVA + " ?", "Conferma cancellazione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                info.Text = "Aggiornamento in corso...";
                progressivo.Style = ProgressBarStyle.Marquee;
                CancellaNominativi.RunWorkerAsync();
            }
        }

        private void CancellaNominativi_DoWork(object sender, DoWorkEventArgs e)
        {
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            OdbcCommand cm = new OdbcCommand();
            cm.Connection = conn;
            cm.CommandText = "DELETE FROM Fattura WHERE CF='" + codiceFiscale + "' AND IVA='" + partitaIVA + "'";
            conn.Open();
            recordAggiornati = cm.ExecuteNonQuery();
            conn.Close();
        }

        private void CancellaNominativi_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Sono state cancellate " + recordAggiornati + " occorrenze nel database");
            info.Text = "Aggiornamento completato.";
            progressivo.Style = ProgressBarStyle.Blocks;
            progressivo.Value = 100;
            this.Close();
        }
    }
}
