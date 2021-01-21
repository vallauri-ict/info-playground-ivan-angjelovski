using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_Gioco_Tresette
{
    public partial class Form1 : Form
    {
        MazzoCarte carte = new MazzoCarte();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProponi_Click(object sender, EventArgs e)
        {
            carte.Proponi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAggiungiCarta_Click(object sender, EventArgs e)
        {
            MazzoCarte nuovaCarta = new MazzoCarte();
            nuovaCarta.Valore = cmbValore.Text;
            nuovaCarta.Seme = cmbSeme.Text;
            nuovaCarta.InserisciCarta(nuovaCarta);
        }
    }
}
