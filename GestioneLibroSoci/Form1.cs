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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace GestioneLibroSoci
{
    public partial class Home : Form
    {
        public List<DateTime> inizio_stagione,fine_stagione;
        public List<int> ID_Iscrizione;

        public int IndexIDIscrizione;

        public int idSerataPerStampa;


        List<int> tessera = new List<int>();
        List<string> codici = new List<string>();
        List<string> cognomi = new List<string>();
        List<string> nomi = new List<string>();
        List<string> sesso = new List<string>();
        List<string> nascita = new List<string>();
        List<string> provNascita = new List<string>();
        List<string> dataNascita = new List<string>();
        List<string> cf = new List<string>();
        List<string> indirizzo = new List<string>();
        List<string> comune = new List<string>();
        List<string> cap = new List<string>();
        List<string> frazione = new List<string>();
        List<string> provResidenza = new List<string>();
        List<string> cellulare = new List<string>();
        List<string> telefono = new List<string>();
        List<string> email = new List<string>();

        int indiceStampeModuli = 0;
        public int SecondiTrascorsiStampaModuli;

        public Home()
        {
            InitializeComponent();
            notifica.DoubleClick += new EventHandler(notifica_DoubleClick);
            esci.Click += new EventHandler(esci_Click);
            CaricaLibro();
            CheckNews();
            GeneraSottomenuStampaSoci();
            GeneraSottomenuStampaEventi();
            GeneraSottomenuStampaFatture();
            GeneraSottomenuAbbonamenti();
            PrimoAvvio();
        }

        void esci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void notifica_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        public void PrimoAvvio()
        {
            string cartella = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            if (!Directory.Exists(cartella + "\\LibroSoci"))
            {
                Directory.CreateDirectory(cartella + "\\LibroSoci");
                File.CreateText(cartella + "\\LibroSoci\\account.ini");
                File.CreateText(cartella + "\\LibroSoci\\printer.ini");
            }
            else
            {
                if (!File.Exists(cartella + "\\LibroSoci\\account.ini"))
                    File.CreateText(cartella + "\\LibroSoci\\account.ini");

                if (!File.Exists(cartella + "\\LibroSoci\\printer.ini"))
                    File.CreateText(cartella + "\\LibroSoci\\printer.ini");
            }

            /*AGGIUNTA DSN */
        }

        public void GeneraSottomenuAbbonamenti()
        {
            List<string> nomeTipologia = new List<string>();
            List<int> idTipologia = new List<int>();
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT Nome,IDTipologia FROM Tipologia";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                nomeTipologia.Add(dr["Nome"].ToString());
                idTipologia.Add(int.Parse(dr["IDTipologia"].ToString()));
            }
            conn.Close();

            ToolStripMenuItem[] items = new ToolStripMenuItem[nomeTipologia.Count];
            for (int i = 0; i < nomeTipologia.Count; i++)
            {
                items[i] = new ToolStripMenuItem();
                items[i].Name = idTipologia[i].ToString();
                items[i].Text = nomeTipologia[i];

                ToolStripMenuItem sottomenuNuoviAbbonamenti = new ToolStripMenuItem();
                sottomenuNuoviAbbonamenti.Name = idTipologia[i].ToString();
                sottomenuNuoviAbbonamenti.Text = "Inserisci nuovo";
                sottomenuNuoviAbbonamenti.Click += new EventHandler(InserisciAbbonamento);
                items[i].DropDownItems.Add(sottomenuNuoviAbbonamenti);

                ToolStripMenuItem sottomenuStampaAbbonamenti = new ToolStripMenuItem();
                sottomenuStampaAbbonamenti.Name = idTipologia[i].ToString();
                sottomenuStampaAbbonamenti.Text = "Stampa abbonati";
                sottomenuStampaAbbonamenti.Click += new EventHandler(StampaAbbonamenti);
                items[i].DropDownItems.Add(sottomenuStampaAbbonamenti);

                ToolStripMenuItem sottomenuSaldaPagamenti = new ToolStripMenuItem();
                sottomenuSaldaPagamenti.Name = idTipologia[i].ToString();
                sottomenuSaldaPagamenti.Text = "Salda pagamenti";
                sottomenuSaldaPagamenti.Click+=new EventHandler(SaldaPagamenti);
                items[i].DropDownItems.Add(sottomenuSaldaPagamenti);

                ToolStripMenuItem sottomenuCancellaIscrizione = new ToolStripMenuItem();
                sottomenuCancellaIscrizione.Name = idTipologia[i].ToString();
                sottomenuCancellaIscrizione.Text = "Cancella iscrizione";
                sottomenuCancellaIscrizione.Click += new EventHandler(sottomenuCancellaIscrizione_Click);
                items[i].DropDownItems.Add(sottomenuCancellaIscrizione);

            }
            serviziToolStripMenuItem.DropDownItems.AddRange(items);
        }

        void sottomenuCancellaIscrizione_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            int idTipol = int.Parse(clickedItem.Name);
            Cancella_abbonato form = new Cancella_abbonato(idTipol);
            try
            {
                form.ShowDialog();
            }
            catch { ;}
        }

        void InserisciAbbonamento(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            int idTipol = int.Parse(clickedItem.Name);
            InserisciAbbonato form = new InserisciAbbonato(idTipol);
            try
            {
                form.ShowDialog();
            }
            catch { ;}
        }

        void StampaAbbonamenti(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            int idTipol = int.Parse(clickedItem.Name);

            string nomeAbbonamento = "";
            int lezioni = 0;
            decimal quota = 0;

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT Nome,NumeroLezioni,Quota FROM Tipologia WHERE IDTipologia="+idTipol;
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                nomeAbbonamento = dr["Nome"].ToString();
                lezioni = int.Parse(dr["NumeroLezioni"].ToString());
                quota = decimal.Parse(dr["Quota"].ToString());
                quota = decimal.Round(quota, 2);
                
                dr.Close();

                List<int> idSocio1, idSocio2;
                List<DateTime> scadenza = new List<DateTime>();
                List<string> pagato = new List<string>();
                idSocio1 = new List<int>();
                idSocio2 = new List<int>();
                pagato = new List<string>();

                List<int> idAbbonamento = new List<int>();

                cm.CommandText = "SELECT IDSocio1,IDSocio2,Pagato,Scadenza,IDAbbonamento FROM Abbonamento WHERE IDTipologia=" + idTipol + " AND Scadenza>='" + DateTime.Now.ToShortDateString() + "'";
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    idSocio1.Add(int.Parse(dr["IDSocio1"].ToString()));
                    idSocio2.Add(int.Parse(dr["IDSocio2"].ToString()));
                    pagato.Add(dr["Pagato"].ToString());
                    scadenza.Add(DateTime.Parse(dr["Scadenza"].ToString()));
                    idAbbonamento.Add(int.Parse(dr["IDAbbonamento"].ToString()));
                }
                dr.Close();

                Excel._Application oXl;
                Excel._Workbook oWB;
                Excel._Worksheet oSheet;
                Excel.Range oRng;

                oXl = new Excel.Application();
                oXl.Visible = true;
                oWB = (Excel._Workbook)(oXl.Workbooks.Add(Type.Missing));
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                oSheet.Cells[1, 1] = nomeAbbonamento;   //TITOLO
                oSheet.get_Range("A1", "K1").Font.Size = 22;
                oSheet.get_Range("A1", "K1").Merge();
                oSheet.get_Range("A1", "K1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                oSheet.Cells[2, 1] = "N.T.";
                oRng = oSheet.get_Range("A2", "A2");
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                oSheet.Cells[2, 2] = "Coppie";
                oRng = oSheet.get_Range("B2", "C2");
                oRng.Merge();
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                oSheet.Cells[2, 4] = "Cellulare";
                oRng = oSheet.get_Range("D2", "D2");
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                oSheet.Cells[2, 5] = "Cert.";
                oRng = oSheet.get_Range("E2", "E2");
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                oSheet.Cells[2, 6] = "Lezioni";
                oRng = oSheet.get_Range("F2", "H2");
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
                oRng.Merge();
                oSheet.get_Range("F2", "H2").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                oSheet.Cells[2, 9] = "Scadenza";
                oRng = oSheet.get_Range("I2", "I2");
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                oSheet.Cells[2, 10] = "Quota";
                oRng = oSheet.get_Range("J2", "J2");
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                oSheet.Cells[2, 11] = "Pag.";
                oRng = oSheet.get_Range("K2", "K2");
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                int riga = 3;
                int conta = 1;
                #region intestazione
                for (int i = 0; i < lezioni;)
                {
                    int col = 6;
                   
                    for (int j = 0; j < 3 && i < lezioni; j++,i++)
                    {
                        oSheet.Cells[riga, col] = conta;
                        oRng = oSheet.Cells[riga, col];
                        oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                        oRng = oSheet.get_Range("A2", "A" + riga);
                        oRng.Merge();
                        oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                        oRng = oSheet.get_Range("B2", "C" + riga);
                        oRng.Merge();
                        oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                        oRng = oSheet.get_Range("D2", "D" + riga);
                        oRng.Merge();
                        oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                        oRng = oSheet.get_Range("E2", "E" + riga);
                        oRng.Merge();
                        oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                        oRng = oSheet.get_Range("I2", "I" + riga);
                        oRng.Merge();
                        oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                        oRng = oSheet.get_Range("J2", "J" + riga);
                        oRng.Merge();
                        oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                        oRng = oSheet.get_Range("K2", "K" + riga);
                        oRng.Merge();
                        oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Cells.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                        col++;
                        conta++;
                    }
                    riga++;
                }
                #endregion

                int primaRiga = riga;
                for (int i = 0; i < idSocio1.Count; i++)
                {
                     primaRiga = riga;

                    cm.CommandText = "SELECT Nome,Cognome,Cellulare FROM Socio WHERE Tessera=" + idSocio1[i];
                    dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        string nome = dr["Nome"].ToString();
                        string cognome = dr["Cognome"].ToString();
                        string cellulare = dr["Cellulare"].ToString();

                        oSheet.Cells[riga, 1] = idSocio1[i];
                        oSheet.Cells[riga, 2] = cognome + " " + nome;
                        oSheet.Cells[riga, 4] = cellulare;

                        dr.Close();

                        cm.CommandText = "select MAX(Data_Scadenza) FROM Certificato where ID_SOCIO=" + idSocio1[i] + " AND Data_Scadenza>=GETDATE()";
                        dr = cm.ExecuteReader();
                        if (dr.Read())
                        {
                            DateTime data;
                            DateTime.TryParse(dr[0].ToString(), out data);
                            if (data.Equals(DateTime.MinValue))
                                oSheet.Cells[riga, 5] = "NO";
                            else oSheet.Cells[riga, 5] = "SI";

                        }
                        dr.Close();

                    }
                    dr.Close();
                    riga++;

                    cm.CommandText = "SELECT Nome,Cognome,Cellulare FROM Socio WHERE Tessera=" + idSocio2[i];
                    dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        string nome = dr["Nome"].ToString();
                        string cognome = dr["Cognome"].ToString();
                        string cellulare = dr["Cellulare"].ToString();

                        oSheet.Cells[riga, 1] = idSocio2[i];
                         
                        oSheet.Cells[riga, 2] = cognome + " " + nome;
                        oSheet.Cells[riga, 4] = cellulare;

                        dr.Close();

                        cm.CommandText = "select MAX(Data_Scadenza) FROM Certificato where ID_SOCIO=" + idSocio2[i] + " AND Data_Scadenza>=GETDATE()";
                        dr = cm.ExecuteReader();
                        if (dr.Read())
                        {
                            DateTime data;
                            DateTime.TryParse(dr[0].ToString(), out data);
                            if (data.Equals(DateTime.MinValue))
                                oSheet.Cells[riga, 5] = "NO";
                            else oSheet.Cells[riga, 5] = "SI";

                        }
                        dr.Close();

                    }
                    dr.Close();

                    oRng = oSheet.Cells[riga, 9];
                    oRng.Cells.NumberFormat = "@";
                    oSheet.Cells[riga, 9] = scadenza[i].ToShortDateString();

                    string tmpQuota = quota.ToString();
                    if (!tmpQuota.Contains(','))
                        tmpQuota += ",00";
                    oSheet.Cells[riga, 10] = tmpQuota;

                    if (pagato[i].Equals("True"))
                        oSheet.Cells[riga, 11] = "SI";
                    else
                        oSheet.Cells[riga, 11] = "NO";

                    List<DateTime> dateLezioni = new List<DateTime>();
                    cm.CommandText = "SELECT Data FROM Lezione WHERE IDAbbonamento=" + idAbbonamento[i];
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        dateLezioni.Add(DateTime.Parse(dr["Data"].ToString()));
                    }
                    dr.Close();

                    riga--;

                    for (int j = 0; j < dateLezioni.Count; )
                    {
                        int col = 6;
                        for (int k = 0; k < 3 && j < dateLezioni.Count; k++, j++)
                        {
                            oRng = oSheet.Cells[riga, col];
                            oRng.Cells.NumberFormat = "@";
                            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

                            oSheet.Cells[riga, col] = dateLezioni[j].ToShortDateString();

                            col++;
                        }
                        riga++;
                    }


                    oRng = oSheet.get_Range("A" + primaRiga, "A" + riga);
                    oRng.BorderAround(Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(178, 178, 178)));

                    oRng = oSheet.get_Range("B" + primaRiga, "B" + riga);
                    oRng.BorderAround(Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(178, 178, 178)));

                    oRng = oSheet.get_Range("C" + primaRiga, "C" + riga);
                    oRng.BorderAround(Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(178, 178, 178)));

                    oRng = oSheet.get_Range("D" + primaRiga, "D" + riga);
                    oRng.BorderAround(Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(178, 178, 178)));

                    oRng = oSheet.get_Range("E" + primaRiga, "E" + riga);
                    oRng.BorderAround(Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(178, 178, 178)));

                    oRng = oSheet.get_Range("I" + primaRiga, "I" + riga);
                    oRng.BorderAround(Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(178, 178, 178)));

                    oRng = oSheet.get_Range("J" + primaRiga, "J" + riga);
                    oRng.BorderAround(Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(178, 178, 178)));

                    oRng = oSheet.get_Range("K" + primaRiga, "K" + riga);
                    oRng.BorderAround(Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(178, 178, 178)));

                    oRng = oSheet.get_Range("A" + primaRiga, "K" + riga);
                    riga++;
                    oRng.BorderAround(Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(178, 178, 178)));
                    //oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
                    
                }

                //oRng = oSheet.get_Range("A" + primaRiga, "K" + riga);
                //oRng.BorderAround(Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexNone, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(178, 178, 178)));

                oRng = oSheet.get_Range("C1", Missing.Value);
                oRng.EntireColumn.Delete(Missing.Value);
                oSheet.Columns.AutoFit();

                oSheet.PageSetup.LeftMargin = 0.64;
                oSheet.PageSetup.RightMargin = 0.64;
            }
        }

        void InserisciLezione(object sender, EventArgs e)
        {

        }

        void SaldaPagamenti(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            int idTipol = int.Parse(clickedItem.Name);
            try
            {
                Pagamento_Abbonamenti form = new Pagamento_Abbonamenti(idTipol);
                form.ShowDialog();
            }
            catch { ;}
        }
        public void GeneraSottomenuStampaFatture()
        {
            List<int> annoFatture = new List<int>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT DISTINCT(YEAR(DATA)) FROM Fattura";
            cm.Connection = conn;
             OdbcDataReader dr = cm.ExecuteReader();
             while (dr.Read())
             {
                 annoFatture.Add(int.Parse(dr[0].ToString()));
             }
             conn.Close();

             ToolStripMenuItem[] items = new ToolStripMenuItem[annoFatture.Count];
             for (int i = 0; i < annoFatture.Count; i++)
             {
                 items[i] = new ToolStripMenuItem();
                 items[i].Name = annoFatture[i].ToString();
                 items[i].Text = annoFatture[i].ToString();
                 items[i].Click+=new EventHandler(StampaAnno);
             }
             stampaFatturePerAnnoToolStripMenuItem.DropDownItems.AddRange(items);
        }

        void StampaAnno(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            List<int> nFattura = new List<int>();
            int anno = int.Parse(clickedItem.Name.ToString());

        }

        public void GeneraSottomenuStampaEventi()
        {
            List<int> idSerata;
            List<string> nomeEvento;
            List<DateTime> dataEvento;

            idSerata = new List<int>();
            nomeEvento = new List<string>();
            dataEvento = new List<DateTime>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT IDSerata,Nome,Giorno FROM SerataDanzante WHERE Giorno<='" + DateTime.Now.ToShortDateString() + "'  AND Giorno >='" + DateTime.Now.AddMonths(-12).ToShortDateString() + "' ORDER BY(Giorno)";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                idSerata.Add(int.Parse(dr["IDSerata"].ToString()));
                nomeEvento.Add(dr["Nome"].ToString());
                dataEvento.Add(DateTime.Parse(dr["Giorno"].ToString()));
            }
            conn.Close();

            ToolStripMenuItem[] items = new ToolStripMenuItem[idSerata.Count];
            for (int i = 0; i < nomeEvento.Count; i++)
            {
                items[i] = new ToolStripMenuItem();
                items[i].Name = idSerata[i].ToString();
                items[i].Text = nomeEvento[i] + " del " + dataEvento[i].ToShortDateString();
                items[i].Click += new EventHandler(Home_Click);
                
            }

            perEventoToolStripMenuItem.DropDownItems.AddRange(items);
        }

        void Home_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            StampaIngressiEvento(int.Parse(clickedItem.Name),clickedItem.Text);
        }

        public void StampaIngressiEvento(int idSer,string intestazione)
        {
            List<int> tessera = new List<int>();
            List<string> cognome = new List<string>();
            List<string> nome = new List<string>();
            List<DateTime> ora = new List<DateTime>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT Tessera,Nome,Cognome,Ora FROM Socio,Ingresso WHERE IDSerataDanzante=" + idSer + " AND Socio.Codice=Ingresso.Codice";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                tessera.Add(int.Parse(dr["Tessera"].ToString()));
                nome.Add(dr["Nome"].ToString());
                cognome.Add(dr["Cognome"].ToString());
                ora.Add(DateTime.Parse(dr["Ora"].ToString()));
            }
            conn.Close();


            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;

            oXL = new Excel.Application();
            oXL.Visible = true;
            oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(Type.Missing));
            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;
            oSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;
            oSheet.Cells[1, 1] = "INGRESSI "+intestazione;
            oSheet.get_Range("A1", "O1").Merge();
            oSheet.Cells[2, 1] = "N° T.";
            oSheet.Cells[2, 2] = "Cognome";
            oSheet.Cells[2, 3] = "Nome";
            oSheet.Cells[2, 4] = "Ora";

            oSheet.get_Range("A2", "D2").Font.Bold = true;
            oSheet.get_Range("A1", "D1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng = oSheet.get_Range("A1", "D1");
            int i;

            for (i = 0; i < tessera.Count; i++)
            {
                oSheet.Cells[i + 3, 1] = tessera[i];
                oRng = oSheet.get_Range("A2", "A" + (i + 1));
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            }
            oRng = oSheet.get_Range("A2", "A" + (i + 2));
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

            for (i = 0; i < cognome.Count; i++)
            {

                oSheet.Cells[i + 3, 2] = cognome[i];
                oRng = oSheet.get_Range("B2", "B" + (i + 1));
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            }
            oRng = oSheet.get_Range("B2", "B" + (i + 2));
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

            for (i = 0; i < nome.Count; i++)
            {
                oSheet.Cells[i + 3, 3] = nome[i];
                oRng = oSheet.get_Range("C2", "C" + (i + 1));
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            }
            oRng = oSheet.get_Range("C2", "C" + (i + 2));
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

            for (i = 0; i < ora.Count; i++)
            {
                oRng = oSheet.get_Range("D2", "D" + (i + 1));
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
               // oSheet.Cells.NumberFormat = "@";
                oSheet.Cells[i + 3, 4] = ora[i].ToShortTimeString();
            }
            oRng = oSheet.get_Range("D2", "D" + (i + 2));
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;


            oRng = oSheet.get_Range("A2", "D2");
            oRng.EntireColumn.AutoFit();

        }

        public void CheckNews()
        {
            StreamReader sr = new StreamReader("news.ini");
            string txt = sr.ReadLine();
            sr.Close();
            if (txt != "")
            {
                MessageBox.Show(txt);
                StreamWriter sw = new StreamWriter("news.ini");
                sw.WriteLine("");
                sw.Close();
            }
        }

        public void GeneraSottomenuStampaSoci()
        {
            List<DateTime> date_inizio = new List<DateTime>();
            List<DateTime> date_fine = new List<DateTime>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT Data_inizio,Data_fine FROM Iscrizione";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                date_inizio.Add(DateTime.Parse(dr["Data_inizio"].ToString()));
                date_fine.Add(DateTime.Parse(dr["Data_fine"].ToString()));
            }
            dr.Close();
            conn.Close();

            ToolStripMenuItem[] items = new ToolStripMenuItem[date_inizio.Count];
            for (int i = 0; i < date_inizio.Count; i++)
            {
                items[i] = new ToolStripMenuItem();
                items[i].Name = i.ToString();
                items[i].Text = date_inizio[i].Year + " - " + date_fine[i].Year;

                ToolStripMenuItem sottomenuModuli = new ToolStripMenuItem();
                sottomenuModuli.Name = i.ToString();
                sottomenuModuli.Text = "Stampa moduli rinnovo";
                sottomenuModuli.Click += new EventHandler(sottomenu_Click);
                items[i].DropDownItems.Add(sottomenuModuli);

                ToolStripMenuItem sottomenuStampe = new ToolStripMenuItem();
                sottomenuStampe.Name = i.ToString();
                sottomenuStampe.Text = "Stampa elenco";
                sottomenuStampe.Click += new EventHandler(sottomenuStampe_Click);
                items[i].DropDownItems.Add(sottomenuStampe);

                ToolStripMenuItem sottomenuStampaDalAl = new ToolStripMenuItem();
                sottomenuStampaDalAl.Name = i.ToString();
                sottomenuStampaDalAl.Text = "Stampa elenco dal al";
                sottomenuStampaDalAl.Click += new EventHandler(sottomenuStampaDalAl_Click);
                items[i].DropDownItems.Add(sottomenuStampaDalAl);
            }

            stampaIscrittiToolStripMenuItem.DropDownItems.AddRange(items);

            
        }

        void sottomenuStampaDalAl_Click(object sender, EventArgs e)
        {
            //da completare
        }

        void sottomenuStampe_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            IndexIDIscrizione = int.Parse(clickedItem.Name);
            StampaPDFIscritti.RunWorkerAsync();
        }

        void sottomenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            StampaModuliRinnovo(int.Parse(clickedItem.Name));
        }

        public void StampaModuliRinnovo(int idIscrizione)
        {
            List<int> idIscrizioni = new List<int>();
            tessera = new List<int>();
            codici = new List<string>();
            cognomi = new List<string>();
            nomi = new List<string>();
            sesso = new List<string>();
            nascita = new List<string>();
            provNascita = new List<string>();
            dataNascita = new List<string>();
            cf = new List<string>();
            indirizzo = new List<string>();
            comune = new List<string>();
            cap = new List<string>();
            frazione = new List<string>();
            provResidenza = new List<string>();
            cellulare = new List<string>();
            telefono = new List<string>();
            email = new List<string>();
            
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT ID_Iscrizione FROM Iscrizione";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                idIscrizioni.Add(int.Parse(dr["ID_Iscrizione"].ToString()));
            }
            dr.Close();

            cm.CommandText = "SELECT * FROM Socio,Rinnovo WHERE IDIscrizione=" + idIscrizioni[idIscrizione] + " AND IDSocio=ID_Socio ORDER BY(Tessera)";
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                tessera.Add(int.Parse(dr["Tessera"].ToString()));
                codici.Add(dr["Codice"].ToString());
                cognomi.Add(dr["Cognome"].ToString());
                nomi.Add(dr["Nome"].ToString());
                sesso.Add(dr["Sesso"].ToString());
                nascita.Add(dr["Nascita"].ToString());
                provNascita.Add(dr["Provincia_Nascita"].ToString());
                dataNascita.Add(DateTime.Parse(dr["Data_Nascita"].ToString()).ToShortDateString());
                cf.Add(dr["CF"].ToString());
                indirizzo.Add(dr["Indirizzo"].ToString());
                frazione.Add(dr["Frazione"].ToString());
                cap.Add(dr["CAP"].ToString());
                comune.Add(dr["Comune"].ToString());
                provResidenza.Add(dr["Provincia_Residenza"].ToString());
                cellulare.Add(dr["Cellulare"].ToString());
                telefono.Add(dr["Telefono"].ToString());
                email.Add(dr["Email"].ToString());
            }
            dr.Close();

            if (MessageBox.Show("Verranno stampati " + tessera.Count + " moduli. Vuoi continuare?", "Conferma stampa", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                notifica.BalloonTipText = "Stampa in corso...attendi alcuni minuti";
                notifica.BalloonTipIcon = ToolTipIcon.Warning;
                notifica.ShowBalloonTip(5000);
                
                for (int i = 0; i < tessera.Count; i++)
                {
                    indiceStampeModuli = i;
                    Stampa_moduli.PrintController = new System.Drawing.Printing.StandardPrintController();
                    Stampa_moduli.Print();
                }
                
            }
        }

        public void StampaSoci(int indexIscrizione)
        {
            
        }

        public void CaricaLibro()
        {
            int schede = tbStagioni.TabCount;
            for (int i = schede - 1; i >= 0; i--)
            {
                tbStagioni.TabPages.RemoveAt(i);
            }

            inizio: inizio_stagione = new List<DateTime>();
            fine_stagione = new List<DateTime>();
            ID_Iscrizione = new List<int>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT * FROM Iscrizione";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                inizio_stagione.Add(DateTime.Parse(dr["Data_inizio"].ToString()));
                fine_stagione.Add(DateTime.Parse(dr["Data_fine"].ToString()));
                ID_Iscrizione.Add(int.Parse(dr["ID_Iscrizione"].ToString()));
            }
            dr.Close();

            bool stagioneDaInserire = true;
            foreach (DateTime d in fine_stagione)
            {
                if (d > DateTime.Now)
                    stagioneDaInserire = false;
            }

            if (stagioneDaInserire)
            {
                cm.CommandText = "SELECT MAX(Data_fine) FROM Iscrizione";
                dr = cm.ExecuteReader();
                dr.Read();
                DateTime data = new DateTime();
                DateTime.TryParse(dr[0].ToString(), out data);
                dr.Close();
                if (data == DateTime.MinValue)
                    MessageBox.Show("Imposta una data di inizio e fine stagione dal menu Impostazioni!");
                else
                {
                    cm.CommandText = "SELECT Data_inizio from Iscrizione WHERE Data_fine='" + data.ToShortDateString() + "'";
                    DateTime data_inizio;
                    dr = cm.ExecuteReader();
                    dr.Read();
                    data_inizio = DateTime.Parse(dr["Data_inizio"].ToString());
                    dr.Close();

                    data_inizio = data_inizio.AddYears(1);
                    data = data.AddYears(1);
                    cm.CommandText = "INSERT INTO Iscrizione(Data_inizio,Data_fine) VALUES ('" + data_inizio.ToShortDateString() + "','" + data.ToShortDateString() + "')";
                    cm.ExecuteNonQuery();
                    goto inizio;
                }
            }

            for (int i = 0; i < ID_Iscrizione.Count; i++)
            {
                string titolo_tab = inizio_stagione[i].Year.ToString() + " - " + fine_stagione[i].Year.ToString();
                TabPage t = new TabPage(titolo_tab);
                DataGridView d = new DataGridView();
                d.Dock = DockStyle.Fill;
                d.AllowUserToAddRows = false;
                d.AllowUserToDeleteRows = false;
                DataGridViewCell cella = new DataGridViewTextBoxCell();
                DataGridViewCellStyle stile = new DataGridViewCellStyle();
                //stile.Font = new System.Drawing.Font("Arial", 10);
                stile.WrapMode = DataGridViewTriState.True;
                d.RowsDefaultCellStyle = stile;

                DataGridViewColumn colonna_tessera = new DataGridViewColumn();
                colonna_tessera.Name = "Tessera";
                colonna_tessera.HeaderText = "T n°";
                colonna_tessera.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_tessera.CellTemplate = cella;

                DataGridViewColumn colonna_codice = new DataGridViewColumn();
                colonna_codice.Name = "codice";
                colonna_codice.HeaderText = "Codice";
                colonna_codice.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_codice.CellTemplate = cella;

                DataGridViewColumn colonna_cognome = new DataGridViewColumn();
                colonna_cognome.Name = "cognome";
                colonna_cognome.HeaderText = "Cognome";
                colonna_cognome.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_cognome.CellTemplate = cella;

                DataGridViewColumn colonna_nome = new DataGridViewColumn();
                colonna_nome.Name = "nome";
                colonna_nome.HeaderText = "Nome";
                colonna_nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_nome.CellTemplate = cella;

                DataGridViewColumn colonna_nascita = new DataGridViewColumn();
                colonna_nascita.Name = "nascita";
                colonna_nascita.HeaderText = "Luogo nascita";
                colonna_nascita.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_nascita.CellTemplate = cella;

                DataGridViewColumn colonna_prov_nascita = new DataGridViewColumn();
                colonna_prov_nascita.Name = "prov_nascita";
                colonna_prov_nascita.HeaderText = "Prov. nascita";
                colonna_prov_nascita.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_prov_nascita.CellTemplate = cella;

                DataGridViewColumn colonna_data_nascita = new DataGridViewColumn();
                colonna_data_nascita.Name = "data_nascita";
                colonna_data_nascita.HeaderText = "Data nascita";
                colonna_data_nascita.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_data_nascita.CellTemplate = cella;

                DataGridViewColumn colonna_cf = new DataGridViewColumn();
                colonna_cf.Name = "cf";
                colonna_cf.HeaderText = "Codice fiscale";
                colonna_cf.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_cf.CellTemplate = cella;

                DataGridViewColumn colonna_indirizzo = new DataGridViewColumn();
                colonna_indirizzo.Name = "indirizzo";
                colonna_indirizzo.HeaderText = "Indirizzo";
                colonna_indirizzo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_indirizzo.CellTemplate = cella;

                DataGridViewColumn colonna_frazione = new DataGridViewColumn();
                colonna_frazione.Name = "frazione";
                colonna_frazione.HeaderText = "Frazione";
                colonna_frazione.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_frazione.CellTemplate = cella;

                DataGridViewColumn colonna_cap = new DataGridViewColumn();
                colonna_cap.Name = "cap";
                colonna_cap.HeaderText = "CAP";
                colonna_cap.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_cap.CellTemplate = cella;

                DataGridViewColumn colonna_comune = new DataGridViewColumn();
                colonna_comune.Name = "comune";
                colonna_comune.HeaderText = "Comune";
                colonna_comune.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_comune.CellTemplate = cella;

                DataGridViewColumn colonna_prov_residenza = new DataGridViewColumn();
                colonna_prov_residenza.Name = "prov_residenza";
                colonna_prov_residenza.HeaderText = "Prov. residenza";
                colonna_prov_residenza.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_prov_residenza.CellTemplate = cella;

                DataGridViewColumn colonna_cellulare = new DataGridViewColumn();
                colonna_cellulare.Name = "cellulare";
                colonna_cellulare.HeaderText = "Cellulare";
                colonna_cellulare.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_cellulare.CellTemplate = cella;

                DataGridViewColumn colonna_telefono = new DataGridViewColumn();
                colonna_telefono.Name = "telefono";
                colonna_telefono.HeaderText = "Telefono";
                colonna_telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                colonna_telefono.CellTemplate = cella;

                DataGridViewColumn colonna_email = new DataGridViewColumn();
                colonna_email.Name = "email";
                colonna_email.HeaderText = "Email";
                colonna_email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                colonna_email.CellTemplate = cella;

                d.Columns.Add(colonna_tessera);
                d.Columns.Add(colonna_codice);
                d.Columns.Add(colonna_cognome);
                d.Columns.Add(colonna_nome);
                d.Columns.Add(colonna_nascita);
                d.Columns.Add(colonna_prov_nascita);
                d.Columns.Add(colonna_data_nascita);
                d.Columns.Add(colonna_cf);
                d.Columns.Add(colonna_indirizzo);
               // d.Columns.Add(colonna_frazione);
                d.Columns.Add(colonna_cap);
                d.Columns.Add(colonna_comune);
                d.Columns.Add(colonna_prov_residenza);
                d.Columns.Add(colonna_cellulare);
                //d.Columns.Add(colonna_telefono);
                d.Columns.Add(colonna_email);
                
                t.Controls.Add(d);
                d.Dock = DockStyle.Fill;

                cm.CommandText = "SELECT * FROM Socio,Rinnovo WHERE IDiscrizione=" + ID_Iscrizione[i]+" AND Socio.ID_Socio=Rinnovo.IDSocio ORDER BY(Tessera)";
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    List<string> riga = new List<string>();
                    riga.Add(dr["Tessera"].ToString());
                    float codice = float.Parse(dr["Codice"].ToString());
                    riga.Add(codice.ToString());
                    riga.Add(dr["Cognome"].ToString());
                    riga.Add(dr["Nome"].ToString());
                    riga.Add(dr["Nascita"].ToString());
                    riga.Add(dr["Provincia_Nascita"].ToString());
                    riga.Add(DateTime.Parse(dr["Data_nascita"].ToString()).ToShortDateString());
                    riga.Add(dr["CF"].ToString());
                    riga.Add(dr["Indirizzo"].ToString()+" "+dr["Frazione"].ToString());
                   // riga.Add(dr["Frazione"].ToString());
                    riga.Add(dr["CAP"].ToString());
                    riga.Add(dr["Comune"].ToString());
                    riga.Add(dr["Provincia_Residenza"].ToString());
                    riga.Add(dr["Cellulare"].ToString());
                    //riga.Add(dr["Telefono"].ToString());
                    riga.Add(dr["Email"].ToString());

                    d.Rows.Add(riga.ToArray());
                }

                List<string> tmp = new List<string>();
                tmp.Add("TOT");
                tmp.Add(d.Rows.Count.ToString());
                d.Rows.Add(tmp.ToArray());
                d.AutoResizeRows();
               // d.AutoResizeColumns();
                tbStagioni.TabPages.Add(t);
                d.AutoResizeRows();
                dr.Close();
                
            }
            conn.Close();
            tbStagioni.SelectedIndex = tbStagioni.TabPages.Count - 1;
        }

        private void definisciInizioFineStagioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImpostaStagione form = new ImpostaStagione();
            form.ShowDialog();
        }

        private void rinnovaIscrizioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rinnova_iscrizione form = new Rinnova_iscrizione();
            form.ShowDialog();
            CaricaLibro();
        }

        private void modificaAnagraficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifica_Socio form = new Modifica_Socio();
            form.ShowDialog();
            CaricaLibro();
        }

        private void inserisciNuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inserisci_Socio form = new Inserisci_Socio();
            form.ShowDialog();
            CaricaLibro();
        }

        private void StampaPDFIscritti_DoWork(object sender, DoWorkEventArgs e)
        {
            List<int> idIscrizioni = new List<int>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT ID_Iscrizione FROM Iscrizione";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                idIscrizioni.Add(int.Parse(dr["ID_Iscrizione"].ToString()));
            }
            dr.Close();

            List<int> tessera = new List<int>();
            List<string> codici = new List<string>();
            List<string> cognomi = new List<string>();
            List<string> nomi = new List<string>();
            List<string> sesso = new List<string>();
            List<string> nascita = new List<string>();
            List<string> provNascita = new List<string>();
            List<string> dataNascita = new List<string>();
            List<string> cf = new List<string>();
            List<string> indirizzo = new List<string>();
            List<string> comune = new List<string>();
            List<string> cap = new List<string>();
            List<string> frazione = new List<string>();
            List<string> provResidenza = new List<string>();
            List<string> cellulare = new List<string>();
            List<string> telefono = new List<string>();
            List<string> email = new List<string>();

            cm.CommandText = "SELECT * FROM Socio,Rinnovo WHERE IDIscrizione=" + idIscrizioni[IndexIDIscrizione] + " AND IDSocio=ID_Socio ORDER BY(Tessera)";
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                tessera.Add(int.Parse(dr["Tessera"].ToString()));
                codici.Add(dr["Codice"].ToString());
                cognomi.Add(dr["Cognome"].ToString());
                nomi.Add(dr["Nome"].ToString());
                sesso.Add(dr["Sesso"].ToString());
                nascita.Add(dr["Nascita"].ToString());
                provNascita.Add(dr["Provincia_Nascita"].ToString());
                dataNascita.Add(DateTime.Parse(dr["Data_Nascita"].ToString()).ToShortDateString());
                cf.Add(dr["CF"].ToString());
                indirizzo.Add(dr["Indirizzo"].ToString());
                frazione.Add(dr["Frazione"].ToString());
                cap.Add(dr["CAP"].ToString());
                comune.Add(dr["Comune"].ToString());
                provResidenza.Add(dr["Provincia_Residenza"].ToString());
                cellulare.Add(dr["Cellulare"].ToString());
                telefono.Add(dr["Telefono"].ToString());
                email.Add(dr["Email"].ToString());
            }
            dr.Close();

            cm.CommandText = "SELECT Data_inizio,Data_fine FROM Iscrizione WHERE ID_Iscrizione=" + idIscrizioni[IndexIDIscrizione];
            dr = cm.ExecuteReader();
            dr.Read();
            DateTime data_inizio =DateTime.Parse(dr["Data_inizio"].ToString());
            DateTime data_fine = DateTime.Parse(dr["Data_fine"].ToString());
            int annoInizio = data_inizio.Year;
            int annoFine = data_fine.Year;
            dr.Close();
            conn.Close();

            Document documento = new Document(PageSize.A4, 20, 20, 25, 5);

            var output = new MemoryStream();
            var writer = PdfWriter.GetInstance(documento, output);
            documento.Open();

            var titolo = new PdfPTable(2);
            titolo.DefaultCell.Border = 0;
            titolo.TotalWidth = PageSize.A4.Width;
            titolo.LockedWidth = true;
            titolo.DefaultCell.PaddingLeft =0;
            var fontTitolo = FontFactory.GetFont("Arial", 18);
            
            //titolo.SpacingBefore = 600f;
            PdfPCell primaRiga = new PdfPCell(new Phrase("LIBRO SOCI",fontTitolo));
            primaRiga.HorizontalAlignment = Element.ALIGN_CENTER;
            primaRiga.Colspan = 2;
            primaRiga.BorderWidth = 0;

            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(primaRiga);
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            PdfPCell stag = new PdfPCell(new Phrase("Stagione "+annoInizio+" - "+annoFine, fontTitolo));
            stag.Colspan = 2;
            stag.Indent = 50f;
            stag.BorderWidth = 0;
            stag.HorizontalAlignment = Element.ALIGN_CENTER;
            
            titolo.AddCell(stag);

            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));

            PdfPCell dalAl = new PdfPCell(new Phrase("Dal " + data_inizio.ToShortDateString() + " al " + data_fine.ToShortDateString(), fontTitolo));
            dalAl.Colspan = 2;
            dalAl.Indent = 50f;
            dalAl.BorderWidth = 0;
            dalAl.HorizontalAlignment = Element.ALIGN_CENTER;
            titolo.AddCell(dalAl);

            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));
            titolo.AddCell(new Phrase("", fontTitolo));

            PdfPCell aggiornato = new PdfPCell(new Phrase("Aggiornato al " + DateTime.Now.ToShortDateString(), fontTitolo));
            aggiornato.Colspan = 2;
            aggiornato.Indent = 50f;
            aggiornato.BorderWidth = 0;
            aggiornato.HorizontalAlignment = Element.ALIGN_CENTER;
            titolo.AddCell(aggiornato);

            documento.Add(titolo);
            documento.NewPage();
            var fontTabella = FontFactory.GetFont("Calibri", 8);
            var fontDati = FontFactory.GetFont("Calibri", 11);
            fontDati.IsBold();

            var fontPagina = FontFactory.GetFont("Calibri", 7);

            int numPagina = 2;

            for (int i = 0, k=0; i < tessera.Count && k<2;)
            {
                for (int j = 0; j < 4; j++)
                {
                    var tabella = new PdfPTable(4);
                    tabella.DefaultCell.Border = 0;
                    tabella.DefaultCell.PaddingLeft = 40f;
                    tabella.DefaultCell.NoWrap = true;
                    tabella.DefaultCell.PaddingRight = 15f;
                    tabella.TotalWidth = PageSize.A4.Width;
                    tabella.LockedWidth = true;
                    tabella.SpacingAfter = 15f;
                    //tabella.SpacingBefore = -5f;

                    tabella.AddCell(new Phrase("Tessera n.", fontTabella));
                    tabella.AddCell(new Phrase("Cognome:",fontTabella));
                    tabella.AddCell(new Phrase("Nome:",fontTabella));
                    tabella.AddCell(new Phrase("Sesso:", fontTabella));

                    tabella.AddCell(new Phrase(tessera[i].ToString(), fontDati));
                    tabella.AddCell(new Phrase(cognomi[i], fontDati));
                    tabella.AddCell(new Phrase(nomi[i], fontDati));
                    tabella.AddCell(new Phrase(sesso[i], fontDati));

                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));

                    tabella.AddCell(new Phrase("Luogo di nascita:", fontTabella));
                    tabella.AddCell(new Phrase("Prov. (sigla):", fontTabella));
                    tabella.AddCell(new Phrase("Data di nascita:", fontTabella));
                    tabella.AddCell(new Phrase("", fontTabella));

                    tabella.AddCell(new Phrase(nascita[i], fontDati));
                    tabella.AddCell(new Phrase(provNascita[i], fontDati));
                    tabella.AddCell(new Phrase(dataNascita[i], fontDati));
                    tabella.AddCell(new Phrase("", fontDati));

                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));

                    tabella.AddCell(new Phrase("Codice fiscale:", fontTabella));
                    tabella.AddCell(new Phrase("", fontTabella));
                    tabella.AddCell(new Phrase("", fontTabella));
                    tabella.AddCell(new Phrase("", fontTabella));

                    tabella.AddCell(new Phrase(cf[i], fontDati));
                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));

                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));

                    tabella.AddCell(new Phrase("Residenza (Via, Piazza, ecc. e n.):", fontTabella));
                    tabella.AddCell(new Phrase("Frazione:", fontTabella));
                    tabella.AddCell(new Phrase("", fontTabella));
                    tabella.AddCell(new Phrase("", fontTabella));

                    tabella.AddCell(new Phrase(indirizzo[i], fontDati));
                    tabella.AddCell(new Phrase(frazione[i], fontDati));
                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));

                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));

                    tabella.AddCell(new Phrase("CAP:", fontTabella));
                    tabella.AddCell(new Phrase("Comune:", fontTabella));
                    tabella.AddCell(new Phrase("Prov. (sigla):", fontTabella));
                    tabella.AddCell(new Phrase("Codice tessera:", fontTabella));

                    tabella.AddCell(new Phrase(cap[i], fontDati));
                    tabella.AddCell(new Phrase(comune[i], fontDati));
                    tabella.AddCell(new Phrase(provResidenza[i], fontDati));
                    tabella.AddCell(new Phrase(codici[i], fontDati));

                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));
                    tabella.AddCell(new Phrase("", fontDati));

                    tabella.AddCell(new Phrase("Cellulare:", fontTabella));
                    tabella.AddCell(new Phrase("Telefono:", fontTabella));
                    tabella.AddCell(new Phrase("Email:", fontTabella));
                    tabella.AddCell(new Phrase("", fontTabella));

                    tabella.AddCell(new Phrase(cellulare[i], fontDati));
                    tabella.AddCell(new Phrase(telefono[i], fontDati));
                    tabella.AddCell(new Phrase(email[i], fontDati));
                    //if (j == 3 || i==tessera.Count-1)
                    //    tabella.AddCell(new Phrase("Pagina "+numPagina.ToString(), fontPagina));
                    //else
                        tabella.AddCell(new Phrase("", fontDati));

                    if (j != 3 && i<tessera.Count-1)
                    {
                        PdfPCell ultima = new PdfPCell();
                        ultima.Colspan = 4;
                        ultima.BorderWidth = 0;
                        ultima.BorderWidthBottom = 2f;
                        tabella.AddCell(ultima);
                    }

                    if(j==3 || i==tessera.Count-1)
                    {
                        PdfPCell pagina = new PdfPCell();
                        pagina.BorderWidth = 0;
                        tabella.AddCell(new Phrase("", fontPagina));
                        tabella.AddCell(new Phrase("", fontPagina));
                        tabella.AddCell(new Phrase("", fontPagina));
                        tabella.AddCell(new Phrase("Pagina "+numPagina, fontPagina));
                    }

                    documento.Add(tabella);
                    //if (j != 3)
                    //{
                    //    Chunk chkHeader = new Chunk("                                                                              ");
                    //    chkHeader.SetUnderline(1f, 25f);
                    //    Paragraph pHeader = new Paragraph(chkHeader);
                    //    documento.Add(pHeader);
                    //}

                    if (i < tessera.Count - 1)
                        i++;
                    else
                    {

                        break;
                    }
                }
                numPagina++;
                documento.NewPage();
                if (i == tessera.Count - 1)
                    k++;
            }

            documento.Close();

            string nomeFile = DateTime.Now.Ticks.ToString();
            byte[] content = output.ToArray();
            FileStream fs = new FileStream(nomeFile + ".pdf", FileMode.Create);

            fs.Write(content, 0, (int)content.Length);
            fs.Close();
            System.Diagnostics.Process.Start(nomeFile + ".pdf");
        }

        private void perSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuovaFattura form = new NuovaFattura();
            form.ShowDialog();
        }

        private void stampanteFattureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelezionaStampante form = new SelezionaStampante();
            form.ShowDialog();
        }

        private void aggiungiNuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuovoAccountPosta form = new NuovoAccountPosta();
            form.ShowDialog();
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvioEmailAPI form = new InvioEmailAPI();
            form.ShowDialog();
        }

        private void inserisciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserisciCertificato form = new InserisciCertificato();
            form.ShowDialog();
        }

        private void Stampa_moduli_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 43;
            Bitmap intestazione = new Bitmap("intestazione.png");
            e.Graphics.DrawImage(intestazione, x, 50);
            FontStyle stile = new FontStyle();
            stile = FontStyle.Bold;
            e.Graphics.DrawString("MODULO D'ISCRIZIONE ALL'ASSOCIAZIONE", new System.Drawing.Font("Arial", 12, stile), Brushes.Black, x + 200, 175);
            e.Graphics.DrawString("Tessera n. " +tessera[indiceStampeModuli], new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 250);
            e.Graphics.DrawString("Cognome: " + cognomi[indiceStampeModuli], new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 310);
            e.Graphics.DrawString("Nome: " + nomi[indiceStampeModuli], new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 350, 310);
            e.Graphics.DrawString("Codice tessera: " + codici[indiceStampeModuli], new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 350, 250);
            e.Graphics.DrawString("Indirizzo: " + indirizzo[indiceStampeModuli], new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 353);
            e.Graphics.DrawString("C.a.p. " + cap[indiceStampeModuli], new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 350, 353);
            e.Graphics.DrawString("Città: " + comune[indiceStampeModuli], new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 450, 353);
            e.Graphics.DrawString("Frazione: " + frazione[indiceStampeModuli], new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 396);
            e.Graphics.DrawString("Tel. " + telefono[indiceStampeModuli], new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 439);
            e.Graphics.DrawString("Cell. " + cellulare[indiceStampeModuli], new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 175, 439);
            e.Graphics.DrawString("Email: " + email[indiceStampeModuli], new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 350, 439);
            e.Graphics.DrawString("Nato a: " + nascita[indiceStampeModuli], new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 482);
            e.Graphics.DrawString("Prov. (" + provNascita[indiceStampeModuli] + ")", new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 350, 482);
            e.Graphics.DrawString("il " + dataNascita[indiceStampeModuli], new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 450, 482);
            e.Graphics.DrawString("Cod. Fisc. " + cf[indiceStampeModuli], new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 525);
            e.Graphics.DrawString("Attività svolta: BALLO SOCIALE", new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 568);
            e.Graphics.DrawString("FIRMA   ___________________________", new System.Drawing.Font("Calibri", 11, stile), Brushes.Black, x + 450, 606);
            e.Graphics.DrawString("INFORMATIVA EX ART. 13 D.LGS. 196 PER IL TRATTAMENTO DEI DATI PERSONALI", new System.Drawing.Font("Calibri", 11), Brushes.Black, x + 70, 692);
            e.Graphics.DrawString("La informiamo che, secondo la normativa del D.lgs. n. 196 del 30 giugno 2003, il trattamento dei dati da Lei", new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 725);
            e.Graphics.DrawString("forniti avverrà per la sola comunicazione a Lei diretta di informazioni inerenti iniziative e spettacoli", new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 745);
            e.Graphics.DrawString("esclusivamente da parte dell'A.S.D. LISCIO CLUB.", new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 765);
            e.Graphics.DrawString("DICHIARAZIONE LIBERATORIA DI SANA COSTITUZIONE FISICA", new System.Drawing.Font("Calibri", 11, stile), Brushes.Black, x + 120, 840);
            e.Graphics.DrawString("DICHIARO", new System.Drawing.Font("Calibri", 14, stile), Brushes.Black, x + 300, 890);
            e.Graphics.DrawString("sotto la mia responsabilità di essere di sana e robusta costituzione fisica senza controindicazioni di sorta", new System.Drawing.Font("Calibri", 11, stile), Brushes.Black, x, 940);
            e.Graphics.DrawString("alla pratica da me svolta. Dichiaro inoltre che non sussistono indicazioni mediche che impediscano o", new System.Drawing.Font("Calibri", 11, stile), Brushes.Black, x, 960);
            e.Graphics.DrawString("rendano sconsigliabile o pongano dei limiti a qualsiasi pratica motoria e sportiva in genere anche di", new System.Drawing.Font("Calibri", 11, stile), Brushes.Black, x, 980);
            e.Graphics.DrawString("semplice attività ricreativa da me svolta.", new System.Drawing.Font("Calibri", 11, stile), Brushes.Black, x, 1000);
            e.Graphics.DrawString("Data   ______________", new System.Drawing.Font("Calibri", 11), Brushes.Black, x, 1046);
            e.Graphics.DrawString("FIRMA   ___________________________", new System.Drawing.Font("Calibri", 11, stile), Brushes.Black, x + 450, 1046);

        }

        private void timerStampaModuli_Tick(object sender, EventArgs e)
        {

        }

        private void genericaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fattura_Generica form = new Fattura_Generica();
            form.ShowDialog();
        }

        private void cancellaFatturaErrataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancella_fatture form = new Cancella_fatture();
            form.ShowDialog();
        }

        private void stampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> nome, cognome;
            List<int> tessera;
            List<DateTime> scadenza;
            List<bool> agonistico;

            nome = new List<string>();
            cognome = new List<string>();
            tessera= new List<int>();
            scadenza= new List<DateTime>();
            agonistico= new List<bool>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT Tessera,Cognome,Nome,Agonistico,Data_Scadenza FROM Certificato,Socio WHERE Data_Scadenza>='"+DateTime.Now.ToShortDateString()+"' AND Certificato.ID_Socio=Socio.ID_Socio ORDER BY(Cognome)";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                nome.Add(dr["Nome"].ToString());
                cognome.Add(dr["Cognome"].ToString());
                tessera.Add(int.Parse(dr["Tessera"].ToString()));
                scadenza.Add(DateTime.Parse(dr["Data_Scadenza"].ToString()));
                agonistico.Add(bool.Parse(dr["Agonistico"].ToString()));
            }
            dr.Close();
            conn.Close();


            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;

            oXL = new Excel.Application();
            oXL.Visible = true;
            oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(Type.Missing));
            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;
            oSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;
            oSheet.Cells[1, 1] = "ELENCO CERTIFICATI MEDICI";
            oSheet.get_Range("A1", "E1").Merge();
            oSheet.Cells[2, 1] = "N° T.";
            oSheet.Cells[2, 2] = "Cognome";
            oSheet.Cells[2, 3] = "Nome";
            oSheet.Cells[2, 4] = "Scadenza";
            oSheet.Cells[2, 5] = "Tipologia";

            oSheet.get_Range("A2", "E2").Font.Bold = true;
            oSheet.get_Range("A1", "E1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oRng = oSheet.get_Range("A1", "E1");
            int i;

            for (i = 0; i < tessera.Count; i++)  
            {
                oSheet.Cells[i + 3, 1] = tessera[i];
                oRng = oSheet.get_Range("A2", "A" + (i + 1));
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            }
            oRng = oSheet.get_Range("A2", "A" + (i + 2));
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

            for (i = 0; i < cognome.Count; i++) 
            {

                oSheet.Cells[i + 3, 2] = cognome[i];
                oRng = oSheet.get_Range("B2", "B" + (i + 1));
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            }
            oRng = oSheet.get_Range("B2", "B" + (i + 2));
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

            for (i = 0; i < nome.Count; i++)  
            {
                oSheet.Cells[i + 3, 3] = nome[i];
                oRng = oSheet.get_Range("C2", "C" + (i + 1));
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
            }
            oRng = oSheet.get_Range("C2", "C" + (i + 2));
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

            for (i = 0; i < scadenza.Count; i++)  
            {
                oRng = oSheet.get_Range("D2", "D" + (i + 1));
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
                oSheet.Cells.NumberFormat = "@";
                oSheet.Cells[i + 3, 4] = scadenza[i].ToShortDateString();
            }
            oRng = oSheet.get_Range("D2", "D" + (i + 2));
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;


            for (i = 0; i < agonistico.Count; i++)  
            {
                oRng = oSheet.get_Range("E2", "E" + (i + 1));
                oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;
                if (agonistico[i] == true)
                    oSheet.Cells[i + 3, 5] = "NON AGONISTICO";
                else oSheet.Cells[i + 3, 5] = "AGONISTICO";

            }
            oRng = oSheet.get_Range("E2", "E" + (i + 2));
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;


            oRng = oSheet.get_Range("A2", "E2");
            oRng.EntireColumn.AutoFit();

            i++;
            oSheet.Cells[i + 2, 1] = "Dati aggiornati al " + DateTime.Now.ToShortDateString();
        }

        private void creaNuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuovoEvento form = new NuovoEvento();
            form.ShowDialog();
        }

        private void prenotaTavoloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prenotazione_tavolo form = new Prenotazione_tavolo();
            form.ShowDialog();
        }

        private void cancellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancellaEvento form = new CancellaEvento();
            form.ShowDialog();
        }

        private void stampaPrenotazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StampaPrenotazioni form = new StampaPrenotazioni();
            form.ShowDialog();
        }

        private void cancellaIscrizioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AnnullaIscrizione form = new AnnullaIscrizione();
                form.ShowDialog();
            }
            catch { ;}
            CaricaLibro();
        }

        private void liveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngressiLive form = new IngressiLive();
            form.ShowDialog();
        }

        private void informazioniSuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 form = new AboutBox1();
            form.ShowDialog();
        }

        private void stampaFatturePerAnnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifica_nominativi form = new Modifica_nominativi();
            try
            {
                form.ShowDialog();
            }
            catch { ;}
        }

        private void definisciNuovaTipologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuovaTipologiaAbbonamento form = new NuovaTipologiaAbbonamento();
            try
            {
                form.ShowDialog();
            }
            catch { ;}
            Application.Restart();
        }

        private void modificaTipologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifica_abbonamento form = new Modifica_abbonamento();
            try
            {
                form.ShowDialog();
            }
            catch { ;}
        }

        private void eliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elimina_abbonamento form = new Elimina_abbonamento();
            try
            {
                form.ShowDialog();
            }
            catch { ;}
            Application.Restart();
        }

        private void cancellaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cancella_nominativics form = new Cancella_nominativics();
            try
            {
                form.ShowDialog();
            }
            catch { ;}
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason != CloseReason.UserClosing) return;
            //e.Cancel = true;
            //Hide();
            //notifica.BalloonTipText = "Gestione Libro Soci è ancora attivo. Fai doppio clic per riaprirlo";
            //notifica.BalloonTipIcon = ToolTipIcon.Info;
            //notifica.ShowBalloonTip(1000);
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aggiungiNuovoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuovoAccountSMS form = new NuovoAccountSMS();
            form.ShowDialog();
        }

        private void emailTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvioEmailAPI form = new InvioEmailAPI();
            form.ShowDialog();
        }

        private void sMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InviaSMS form = new InviaSMS();
            form.ShowDialog();
        }

    }
}
