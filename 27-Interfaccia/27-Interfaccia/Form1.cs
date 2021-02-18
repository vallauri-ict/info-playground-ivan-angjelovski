using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_Interfaccia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyComponent componente = new MyComponent();

        private void btnConnetti_Click(object sender, EventArgs e)
        {
            componente.connetti("Componente 1");
        }

        private void btnDisconnetti_Click(object sender, EventArgs e)
        {
            componente.disconnetti("Componente 1");
        }

        private void btnStato_Click(object sender, EventArgs e)
        {
            componente.stato();
        }
    }
}
