using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_CodaLibri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            if (txtLibro.Text != "")
            {
                Singleton s = Singleton.GetClsSingleton();
                s.push(txtLibro.Text);
            }
            else
            {
                MessageBox.Show("Inserire un libro");
            }
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            Singleton s = Singleton.GetClsSingleton();
            s.pull();
        }
    }
}
