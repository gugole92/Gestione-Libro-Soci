﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Configuration;
using System.IO;

namespace GestioneLibroSoci
{
    public partial class Fattura_Generica : Form
    {

        public int progressivo;

        public string stampante;

        public List<string> cf;
        public List<string> indirizzi;
        public List<string> iva;

        public Fattura_Generica()
        {
            InitializeComponent();
            CaricaNominativi();
            CaricaProgressivo();
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        public void CaricaProgressivo()
        {
            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT MAX(Progressivo) FROM Fattura WHERE YEAR(Data)=" + DateTime.Now.Year;
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            int numero = 0;
            if (dr.Read())
                try
                {
                    numero = dr.GetInt32(0);
                }
                catch
                {
                    numero = 0;
                }
            progressivo = numero + 1;
            conn.Close();
            dr.Close();

            lblFattura.Text = "Fattura n. " + progressivo;
        }

        public void CaricaNominativi()
        {
            cf = new List<string>();
            indirizzi = new List<string>();
            iva = new List<string>();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.CommandText = "SELECT DISTINCT Nominativo,CF,IVA,Indirizzo FROM Fattura WHERE IDSocio IS NULL ORDER BY(Nominativo) ";
            cm.Connection = conn;
            OdbcDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtNominativo.Items.Add(dr["Nominativo"].ToString());
                cf.Add(dr["CF"].ToString());
                indirizzi.Add(dr["Indirizzo"].ToString());
                iva.Add(dr["IVA"].ToString());
            }
            dr.Close();

            cm.CommandText = "SELECT DISTINCT Descrizione FROM Fattura ORDER BY(Descrizione)";
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbDescrizione.Items.Add(dr["Descrizione"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void txtNominativo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCF.Text = cf[txtNominativo.SelectedIndex];
            txtIndirizzo.Text = indirizzi[txtNominativo.SelectedIndex];
            txtIVA.Text = iva[txtNominativo.SelectedIndex];
        }

        private void txtImporto_TextChanged(object sender, EventArgs e)
        {
            if (txtImporto.Focused)
            {
                try
                {
                    decimal tmp;
                    tmp = (decimal.Parse(txtImporto.Text) * 100) / (100 + int.Parse(txtAliquota.Text));
                    txtImponibile.Text = decimal.Round(tmp, 2).ToString();

                    txtIvaCalcolata.Text = decimal.Round((decimal.Parse(txtImporto.Text) - tmp), 2).ToString();
                }
                catch { }
            }
        }

        private void txtImponibile_TextChanged(object sender, EventArgs e)
        {
            if (txtImponibile.Focused)
            {
                try
                {
                    decimal tmp;
                    tmp = (decimal.Parse(txtImponibile.Text) * int.Parse(txtAliquota.Text)) / 100;
                    txtImporto.Text = decimal.Round(decimal.Parse(txtImponibile.Text) + tmp, 2).ToString();

                    txtIvaCalcolata.Text = decimal.Round(tmp, 2).ToString();
                }
                catch { }
            }
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            stampante = "";
            string cartella = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\LibroSoci";
            StreamReader sr = new StreamReader(cartella + "\\printer.ini");
            if (!sr.EndOfStream)
                stampante = sr.ReadLine();
            if (stampante == "")
            {
                MessageBox.Show("Nessuna stampante fatture impostata! \nVai sotto il menu Impostazioni -> Stampante fatture");
                return;
            }
            sr.Close();

            OdbcConnection conn = new OdbcConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            conn.Open();
            OdbcCommand cm = new OdbcCommand();
            cm.Connection = conn;
            cm.CommandText = "INSERT INTO Fattura(Nominativo,CF,IVA,Quantita,Descrizione,Importo,Aliquota,Data,Progressivo,Indirizzo) VALUES('" + txtNominativo.Text.Replace("'", "''") + "','" + txtCF.Text + "','"+txtIVA.Text+"'," + txtQuantita.Value + ",'" + cmbDescrizione.Text.Replace("'", "''") + "'," + txtImponibile.Text.Replace(',', '.') + "," + txtAliquota.Text + ",'" + txtData.Text + "'," + progressivo + ",'" + txtIndirizzo.Text.Replace("'", "''") + "')";


            cm.ExecuteNonQuery();

            if (MessageBox.Show("Vuoi stampare la fattura?", "Stampa fattura", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                printDocument1.PrinterSettings.PrinterName = stampante;
                printDocument1.PrintController = new System.Drawing.Printing.StandardPrintController();
                printDocument1.Print();
            }

            else
            {
                cm.CommandText = "DELETE FROM Fattura WHERE progressivo=" + progressivo + " AND YEAR(Data)=" + DateTime.Parse(txtData.Text).Year;
                cm.ExecuteNonQuery();
                MessageBox.Show("Fattura annullata");
            }
            conn.Close();

            if (MessageBox.Show("Vuoi inserire un'altra fattura?", "Inserisci nuova", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                txtNominativo.Items.Clear();
                cmbDescrizione.Items.Clear();
                CaricaNominativi();
                CaricaProgressivo();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 25;
            e.Graphics.DrawString("N. ATTR.", new Font("Arial", 6), Brushes.Black, new PointF(250, 130));
            e.Graphics.DrawString(progressivo.ToString().PadLeft(2, '0') + "/" + DateTime.Now.Year.ToString().Remove(0, 2), new Font("Arial", 11), Brushes.Black, new PointF(290, 130));
            e.Graphics.DrawString("DATA", new Font("Arial", 6), Brushes.Black, new PointF(250, 160));
            e.Graphics.DrawString(txtData.Text, new Font("Arial", 11), Brushes.Black, new PointF(290, 160));
            e.Graphics.DrawString("Socio n.   N.S.*", new Font("Arial", 9), Brushes.Black, new PointF(x, 210));
            Rectangle rettSocio = new Rectangle(80, 208, 40, 20);
            e.Graphics.DrawRectangle(Pens.Black, rettSocio);

            e.Graphics.DrawString(txtNominativo.Text, new Font("Arial", 9), Brushes.Black, new PointF(x, 240));
            e.Graphics.DrawString(txtIndirizzo.Text, new Font("Arial", 9), Brushes.Black, new PointF(x, 270));
            e.Graphics.DrawString("C.F. / P. IVA: " + txtCF.Text, new Font("Arial", 9), Brushes.Black, new PointF(x, 300)); ;
            e.Graphics.DrawString("QUANTITÀ: " + txtQuantita.Value, new Font("Arial", 9), Brushes.Black, new PointF(x, 330));
            e.Graphics.DrawString("NATURA E QUALITÀ DEI BENI O DEI SERVIZI: ", new Font("Arial", 9), Brushes.Black, new PointF(x, 360));
            int conta = 0;
            int y = 375;
            string tmp = "";
            foreach (char c in cmbDescrizione.Text)
            {
                tmp += c;
                if (conta < 45)
                {
                    conta++;
                }
                else
                {
                    tmp += "‹";
                    e.Graphics.DrawString(tmp, new Font("Arial", 9), Brushes.Black, new PointF(x, y));
                    y += 15;
                    tmp = "";
                    conta = 0;
                }
            }

            e.Graphics.DrawString(tmp.TrimStart(' '), new Font("Arial", 9), Brushes.Black, new PointF(x, y));

            e.Graphics.DrawString("IMPONIBILE € " + txtImponibile.Text, new Font("Arial", 9), Brushes.Black, new PointF(x, y + 30));
            e.Graphics.DrawString("IMPOSTA IVA " + txtAliquota.Text + "% € " + txtIvaCalcolata.Text, new Font("Arial", 9), Brushes.Black, new PointF(x, y + 60));
            e.Graphics.DrawString("IMPORTO € " + txtImporto.Text, new Font("Arial", 9), Brushes.Black, new PointF(x, y + 90));

            e.Graphics.DrawString("copia per cliente", new Font("Arial", 7), Brushes.Black, new PointF(x, y + 120));
            e.Graphics.DrawString("* Non socio", new Font("Arial", 7), Brushes.Black, new PointF(290, y + 120));

            e.Graphics.DrawString("FATTURA", new Font("Arial", 11), Brushes.Black, new PointF(50, 535));
            Rectangle rettangolo = new Rectangle(135, 535, 20, 20);
            e.Graphics.DrawRectangle(Pens.Black, rettangolo);
            e.Graphics.DrawLine(Pens.Black, 135, 535, 155, 555);
            e.Graphics.DrawLine(Pens.Black, 155, 535, 135, 555);

            e.Graphics.DrawString("RICEVUTA FISCALE", new Font("Arial", 11), Brushes.Black, new PointF(185, 535));
            Rectangle rettangolo2 = new Rectangle(343, 535, 20, 20);
            e.Graphics.DrawRectangle(Pens.Black, rettangolo2);

            x = 440;
            e.Graphics.DrawString("N. ATTR.", new Font("Arial", 6), Brushes.Black, new PointF(640, 130));
            e.Graphics.DrawString(progressivo.ToString().PadLeft(2, '0') + "/" + DateTime.Now.Year.ToString().Remove(0, 2), new Font("Arial", 11), Brushes.Black, new PointF(680, 130));
            e.Graphics.DrawString("DATA", new Font("Arial", 6), Brushes.Black, new PointF(640, 160));
            e.Graphics.DrawString(txtData.Text, new Font("Arial", 11), Brushes.Black, new PointF(680, 160));
            e.Graphics.DrawString("Socio n.   N.S.*", new Font("Arial", 9), Brushes.Black, new PointF(x, 210));
            rettSocio = new Rectangle(495, 208, 40, 20);
            e.Graphics.DrawRectangle(Pens.Black, rettSocio);

            e.Graphics.DrawString(txtNominativo.Text, new Font("Arial", 9), Brushes.Black, new PointF(x, 240));
            e.Graphics.DrawString(txtIndirizzo.Text, new Font("Arial", 9), Brushes.Black, new PointF(x, 270));
            e.Graphics.DrawString("C.F. / P. IVA: " + txtCF.Text, new Font("Arial", 9), Brushes.Black, new PointF(x, 300));
            e.Graphics.DrawString("QUANTITÀ: " + txtQuantita.Value, new Font("Arial", 9), Brushes.Black, new PointF(x, 330));
            e.Graphics.DrawString("NATURA E QUALITÀ DEI BENI O DEI SERVIZI: ", new Font("Arial", 9), Brushes.Black, new PointF(x, 360));
            conta = 0;
            y = 375;
            tmp = "";
            foreach (char c in cmbDescrizione.Text)
            {
                tmp += c;
                if (conta < 45)
                {
                    conta++;
                }
                else
                {
                    tmp += "‹";
                    e.Graphics.DrawString(tmp, new Font("Arial", 9), Brushes.Black, new PointF(x, y));
                    y += 15;
                    tmp = "";
                    conta = 0;
                }
            }

            e.Graphics.DrawString(tmp.TrimStart(' '), new Font("Arial", 9), Brushes.Black, new PointF(x, y));

            e.Graphics.DrawString("IMPONIBILE € " + txtImponibile.Text, new Font("Arial", 9), Brushes.Black, new PointF(x, y + 30));
            e.Graphics.DrawString("IMPOSTA IVA " + txtAliquota.Text + "% € " + txtIvaCalcolata.Text, new Font("Arial", 9), Brushes.Black, new PointF(x, y + 60));
            e.Graphics.DrawString("IMPORTO € " + txtImporto.Text, new Font("Arial", 9), Brushes.Black, new PointF(x, y + 90));

            e.Graphics.DrawString("* Non socio", new Font("Arial", 7), Brushes.Black, new PointF(680, y + 120));

            e.Graphics.DrawString("FATTURA", new Font("Arial", 11), Brushes.Black, new PointF(x, 535));
            rettangolo = new Rectangle(525, 535, 20, 20);
            e.Graphics.DrawRectangle(Pens.Black, rettangolo);
            e.Graphics.DrawLine(Pens.Black, 525, 535, 545, 555);
            e.Graphics.DrawLine(Pens.Black, 545, 535, 525, 555);

            e.Graphics.DrawString("RICEVUTA FISCALE", new Font("Arial", 11), Brushes.Black, new PointF(575, 535));
            rettangolo2 = new Rectangle(733, 535, 20, 20);
            e.Graphics.DrawRectangle(Pens.Black, rettangolo2);
        }
    }
}
