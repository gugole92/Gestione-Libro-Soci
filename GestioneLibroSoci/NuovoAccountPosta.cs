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
    public partial class NuovoAccountPosta : Form
    {
        public NuovoAccountPosta()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string cartella = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\LibroSoci";
            StreamWriter sw = new StreamWriter(cartella+"\\account.ini");
            sw.WriteLine(txtMail.Text + ";" + txtPwd.Text);
            sw.Close();
            MessageBox.Show("Account gmail registrato");
            this.Close();
        }
    }
}
