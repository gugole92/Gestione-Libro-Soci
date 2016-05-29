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
    public partial class Elimina_abbonamento : Form
    {
        List<int> idTipologie;
        List<string> nomeTipologia;

        public Elimina_abbonamento()
        {
            InitializeComponent();
            idTipologie = new List<int>();
            nomeTipologia = new List<string>();

            CaricaTipologie();
        }

        public void CaricaTipologie()
        {
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT IDTipologia,Nome FROM Tipologia";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                idTipologie.Add(int.Parse(dr["IDTipologia"].ToString()));
                nomeTipologia.Add(dr["Nome"].ToString());
            }
            conn.Close();

            foreach (string s in nomeTipologia)
                listaTipologie.Items.Add(s);
            if (listaTipologie.Items.Count > 0)
            {
                listaTipologie.SelectedIndex = 0;
                btnConferma.Enabled = true;
            }
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confermi la cancellazione dell'abbonamento " + listaTipologie.Text + "? Questo comporta anche l'eliminazione di tutti gli abbonamenti attivi e eventuali pagamenti sospesi.", "Conferma cancellazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                List<int> idAbbonamenti = new List<int>();

                OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                conn.Open();
                OdbcCommand cm = new OdbcCommand();
                cm.CommandText = "SELECT IDAbbonamento FROM Abbonamento WHERE IDTipologia="+idTipologie[listaTipologie.SelectedIndex];
                cm.Connection = conn;
                OdbcDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    idAbbonamenti.Add(int.Parse(dr["IDAbbonamento"].ToString()));
                }
                dr.Close();

                for (int i = 0; i < idAbbonamenti.Count; i++)
                {
                    cm.CommandText = "DELETE FROM Lezione WHERE IDAbbonamento=" + idAbbonamenti[i];
                    cm.ExecuteNonQuery();
                }

                cm.CommandText = "DELETE FROM Abbonamento WHERE IDTipologia=" + idTipologie[listaTipologie.SelectedIndex];
                cm.ExecuteNonQuery();

                cm.CommandText = "DELETE FROM Tipologia WHERE IDTipologia=" + idTipologie[listaTipologie.SelectedIndex];
                cm.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Abbonamento cancellato. Il programma verrà riavviato per applicare le modifiche!");
                this.Close();
            }
        }
    }
}
