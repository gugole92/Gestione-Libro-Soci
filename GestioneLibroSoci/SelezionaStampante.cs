using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GestioneLibroSoci
{
    public partial class SelezionaStampante : Form
    {

        public SelezionaStampante()
        {
            InitializeComponent();
            CaricaStampanti();
        }

        public void CaricaStampanti()
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                listaPrt.Items.Add(printer);
            }
            if (listaPrt.Items.Count > 0)
                listaPrt.SelectedIndex = 0;
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            string cartella = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\LibroSoci";
            StreamReader sr = new StreamReader(cartella+"\\printer.ini");
            if (!sr.EndOfStream)
            {
                if (MessageBox.Show("Hai già impostato " + sr.ReadLine() + " come predefinita. Vuoi sovrascrivere l'impostazione?", "Conferma stampante", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    sr.Close();
                    StreamWriter sw = new StreamWriter(cartella+"\\printer.ini");
                    sw.WriteLine(listaPrt.SelectedItem);
                    sw.Close();

                    MessageBox.Show("Impostazione salvata");
                    this.Close();
                }
                else sr.Close();
            }
            else
            {
                sr.Close();
                StreamWriter sw = new StreamWriter(cartella+"\\printer.ini");
                sw.WriteLine(listaPrt.SelectedItem);
                sw.Close();
                MessageBox.Show("Impostazione salvata");
                this.Close();
            }
        }
    }
}
