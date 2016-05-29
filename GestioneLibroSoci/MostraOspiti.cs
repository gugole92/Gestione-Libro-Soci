using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestioneLibroSoci
{
    public partial class MostraOspiti : Form
    {
        public MostraOspiti()
        {
            InitializeComponent();
        }

        public MostraOspiti(int idEvento, int Tavolo)
        {
            InitializeComponent();
            this.Text = "Visualizza ospiti per il tavolo " + Tavolo;
        }
    }
}
