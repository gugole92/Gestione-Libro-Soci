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
    public partial class ImpostaStagione : Form
    {
        public ImpostaStagione()
        {
            InitializeComponent();
        }

        private void ImpostaStagione_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Vuoi salvare le impostazioni?", "Conferma salvataggio", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                conn.Open();
                OdbcCommand cm = new OdbcCommand();
                cm.CommandText = "SELECT Data_inizio,Data_fine FROM Iscrizione WHERE YEAR(Data_fine)='" + DataInizio.Value.Year + "'";
                cm.Connection = conn;
                OdbcDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    DateTime inizio = DateTime.Parse(dr["Data_inizio"].ToString());
                    DateTime fine = DateTime.Parse(dr["Data_fine"].ToString());

                    dr.Close();
                    if (MessageBox.Show("Hai già definito la stagione per quest'anno dal " + inizio.ToShortDateString() + " al " + fine.ToShortDateString() + ". Vuoi sovrascrivere i dati?", "Conferma salvataggio", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        cm.CommandText = "UPDATE Iscrizione SET Data_inizio='" + DataInizio.Value.ToShortDateString() + "' WHERE YEAR(Data_inizio)='" + DataInizio.Value.Year + "'";
                        cm.ExecuteNonQuery();

                        cm.CommandText = "UPDATE Iscrizione SET Data_fine='" + DataFine.Value.ToShortDateString() + "' WHERE YEAR(Data_inizio)='" + DataInizio.Value.Year + "'";
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Impostazioni salvate nel database.");
                        conn.Close();
                    }
                }

                else
                {
                    dr.Close();
                    cm.CommandText = "INSERT INTO Iscrizione(Data_inizio,Data_fine) VALUES ('" + DataInizio.Value.ToShortDateString() + "','" + DataFine.Value.ToShortDateString() + "')";
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Impostazioni salvate nel database.");
                    conn.Close();
                }
            }
        }
    }
}
