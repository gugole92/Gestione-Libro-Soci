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
    public partial class AnnullaIscrizione : Form
    {
        public AnnullaIscrizione()
        {
            InitializeComponent();

            CercaSocio form = new CercaSocio();
            form.ShowDialog();
            try
            {
                if (form.tesseraSelezionata == 0)
                    this.Close();
                else
                {
                    if (MessageBox.Show("Confermi la cancellazione dell'iscrizione al socio N° " + form.tesseraSelezionata + "?", "Conferma cancellazione", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                        conn.Open();
                        OdbcCommand cm = new OdbcCommand();
                        cm.CommandText = "SELECT MAX(ID_Iscrizione) FROM Iscrizione";
                        cm.Connection = conn;
                        OdbcDataReader dr = cm.ExecuteReader();
                        int idIscrizione = 0;
                        if (dr.Read())
                        {
                            idIscrizione = int.Parse(dr[0].ToString());
                        }
                        dr.Close();

                        cm.CommandText = "DELETE FROM Rinnovo WHERE IDIscrizione=" + idIscrizione + " AND IDSocio=" + form.tesseraSelezionata;
                        if (cm.ExecuteNonQuery() > 0)
                            MessageBox.Show("Iscrizione annullata");
                        conn.Close();
                        this.Close();
                    }
                    else this.Close();
                }
            }
            catch { ;}
        }
    }
}
