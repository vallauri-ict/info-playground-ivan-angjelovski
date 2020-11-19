using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Gestione_Container
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct container
        {
            public int codice;
            public int peso;
            public int tara;
        }

        public Stack<container> pila = new Stack<container>();

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            container c = new container();
            c.codice = Convert.ToInt32(txtCodice.Text);
            c.peso = Convert.ToInt32(txtPeso.Text);
            c.tara = Convert.ToInt32(txtTara.Text);
            pila.Push(c);
            txtCodice.Text = "";
            txtPeso.Text = "";
            txtTara.Text = "";
            txtCodice.Focus();
        }

        private void btnEstrai_Click(object sender, EventArgs e)
        {
            try
            {
                container c = new container();
                c = pila.Pop();
                MessageBox.Show("Container Estratto: " + "\nCodice → " + c.codice +
                                "\nPeso → " + c.peso + "\nTara → " + c.tara);
            }
            catch (Exception)
            {
                MessageBox.Show("Non ci sono più container");
            }

        }
    }
}
