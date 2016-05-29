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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace GestioneLibroSoci
{
    public partial class StampaPrenotazioni : Form
    {
        public List<int> idEvento;
        public List<string> nomeEvento;
        public List<DateTime> dataEvento;

        public StampaPrenotazioni()
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
            else
                btnConferma.Enabled = false;
        }

        private void listaEventi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGiorno.Text = dataEvento[listaEventi.SelectedIndex].ToShortDateString();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            Excel._Application oXl;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;

            oXl = new Excel.Application();
            oXl.Visible = true;
            oWB = (Excel._Workbook)(oXl.Workbooks.Add(Type.Missing));
            oSheet = (Excel._Worksheet)oWB.ActiveSheet;

            oSheet.Cells[1, 1] = "PRENOTAZIONE TAVOLI";   //TITOLO
            oSheet.get_Range("A1", "A1").Font.Size = 20;
            oSheet.get_Range("A1", "I1").Merge();
            oSheet.get_Range("A1", "I1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            oSheet.Cells[2, 1] = "Evento: " + listaEventi.Text;
            oSheet.get_Range("A2", "G3").Font.Size = 18;
            oSheet.get_Range("A2", "G3").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            oSheet.get_Range("A2", "G3").Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng = oSheet.get_Range("A2", "G3");
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            oSheet.get_Range("A2", "G3").Merge();  //NOME EVENTO

            oSheet.Cells[2, 8] = "Data";
            oRng = oSheet.get_Range("H2", "I2");
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oSheet.get_Range("H2", "I2").Merge(); //data

            oSheet.Cells[3, 8] = dataEvento[listaEventi.SelectedIndex].Day + "-" + dataEvento[listaEventi.SelectedIndex].ToString("MMM") + "-" + dataEvento[listaEventi.SelectedIndex].Year;
            oRng = oSheet.get_Range("H3", "I3");
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Font.Bold = true;
            oRng.Merge();

            oSheet.Cells[4, 1] = "Cognome e nome";
            oRng = oSheet.get_Range("A4", "C5");
            oRng.Font.Size = 14;
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Merge();

            oSheet.Cells[4, 4] = "tessera";
            oRng = oSheet.get_Range("D4", "D5");
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Merge();

            oSheet.Cells[4, 5] = "persone";
            oRng = oSheet.get_Range("E4", "E5");
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Merge();

            oSheet.Cells[4, 6] = "tavolo";
            oRng = oSheet.get_Range("F4", "F5");
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Merge();

            oSheet.Cells[4, 7] = "pagato";
            oRng = oSheet.get_Range("G4", "G5");
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Merge();

            oSheet.Cells[4, 8] = "Note";
            oRng = oSheet.get_Range("H4", "I5");
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng.Merge();

            List<string> cognomi = new List<string>();
            List<string> nomi = new List<string>();
            List<int> tessere = new List<int>();
            List<int> persone= new List<int>();
            List<int>tavoli=new List<int>();
            List<string> pagati = new List<string>();
            List<string> note = new List<string>();
            List<int> idNominativi=new List<int>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT * FROM Nominativo WHERE IDIngresso="+idEvento[listaEventi.SelectedIndex];
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cognomi.Add(dr["Cognome"].ToString());
                nomi.Add(dr["Nome"].ToString());
                tessere.Add(int.Parse(dr["Tessera"].ToString()));
                persone.Add(int.Parse(dr["Persone"].ToString()));
                tavoli.Add(int.Parse(dr["NTavolo"].ToString()));
                pagati.Add((dr["Pagato"].ToString()));
                note.Add(dr["Note"].ToString());
                idNominativi.Add(int.Parse(dr["IDNominativo"].ToString()));
            }
            dr.Close();

            int riga = 6;
            for (int i = 0; i < tessere.Count; i++)
            {
                int primaRiga=riga;
                oSheet.Cells[riga, 1] = cognomi[i] + " " + nomi[i];
                oRng= oSheet.get_Range("A" + riga, "C" + (riga+1));
                oRng.Font.Size = 12;
                oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Merge();

                if (tessere[i].ToString() == "0")
                    oSheet.Cells[riga, 4] = "N.S.";
                else
                    oSheet.Cells[riga, 4] = tessere[i];
                oRng = oSheet.get_Range("D" + riga, "D" + (riga + 1));
                oRng.Font.Size = 12;
                oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
                oRng.Merge();

                oSheet.Cells[riga, 5] = persone[i];
                oRng = oSheet.get_Range("E" + riga, "E" + (riga + 1));
                oRng.Font.Size = 12;
                oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
                oRng.Merge();

                oSheet.Cells[riga, 6] = tavoli[i];
                oRng = oSheet.get_Range("F" + riga, "F" + (riga + 1));
                oRng.Font.Size = 12;
                oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
                oRng.Merge();

                if (pagati[i] == "True")
                    oSheet.Cells[riga, 7] = "SI";
                else oSheet.Cells[riga, 7] = "NO";
                oRng = oSheet.get_Range("G" + riga, "G" + (riga + 1));
                oRng.Font.Size = 12;
                oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
                oRng.Merge();

                oSheet.Cells[riga,8] = note[i];
                oRng = oSheet.get_Range("H" + riga, "I" + (riga + 1));
                oRng.Font.Size = 8;
                oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
                oRng.WrapText = true;
                oRng.Merge();

                List<string> nominativo = new List<string>();
                List<string> noteOspite = new List<string>();
                List<string> tessera = new List<string>();
                List<string> OspitiPagati = new List<string>();

                cm.CommandText = "SELECT * FROM Ospite WHERE IDIngresso=" + idEvento[listaEventi.SelectedIndex] + " AND IDNominativo=" + idNominativi[i];
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    nominativo.Add(dr["Nome"].ToString());
                    noteOspite.Add(dr["Note"].ToString());
                    tessera.Add(dr["Tessera"].ToString());
                    OspitiPagati.Add(dr["Pagato"].ToString());
                }
                dr.Close();

                riga += 2;
                for (int j = 0; j < nominativo.Count; j++,riga++)
                {
                    oSheet.Cells[riga, 1] = nominativo[j];
                    oRng = oSheet.get_Range("A" + riga, "C" + riga);
                    oRng.Merge();

                    if (tessera[j] == "0")
                        oSheet.Cells[riga, 4] = "N.S.";
                    else
                        oSheet.Cells[riga, 4] = tessera[j];
                    oRng = oSheet.get_Range("D" + riga, "D" + riga);
                    oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
                    oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    if (OspitiPagati[j] == "True")
                        oSheet.Cells[riga, 7] = "SI";
                    else
                        oSheet.Cells[riga, 7] = "NO";
                    oRng = oSheet.get_Range("G" + riga, "G" + riga);
                    oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
                    oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    oSheet.Cells[riga, 8] = noteOspite[j];
                    oRng = oSheet.get_Range("H" + riga, "I" + riga);
                    oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
                    oRng.Font.Size = 6;
                    oRng.Merge();

                    oRng = oSheet.get_Range("E" + riga, "F" + riga);
                    oRng.Merge();
                    oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
                }
                riga--;
                oRng = oSheet.get_Range("A" + primaRiga, "C" + riga);
                oRng.BorderAround(Excel.XlLineStyle.xlContinuous,
        Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin,
        Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone,
        System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(178, 178, 178)));
                
                riga++;
            }
            riga += 1;
            oSheet.Cells[riga, 1] = "Aggiornato al " + DateTime.Now.ToShortDateString();
            oXl.UserControl = true;
        }
    }
}
