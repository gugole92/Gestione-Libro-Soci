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
    public partial class NuovaTipologiaAbbonamento : Form
    {
        public NuovaTipologiaAbbonamento()
        {
            InitializeComponent();
            componenti.SelectedIndex = 0;
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "INSERT INTO Tipologia(Nome,NumeroLezioni,Valido,Componente,Quota) VALUES ('" + txtNome.Text + "'," + lezioni.Value + "," + valido.Value + ",'" + componenti.Text + "'," + txtQuota.Text.Replace(',','.') + ")";
            cm.Connection = conn;
            if (cm.ExecuteNonQuery() > 0)
                MessageBox.Show("Abbonamento inserito nel database. Il programma verrà riavviato per applicare le modifiche!");
            conn.Close();
            this.Close();
        }
    }
}
