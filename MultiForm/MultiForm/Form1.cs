using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // dichiarazione form2
            f2.Show(); // visualizza form

        }

        private void btnForm2B_Click(object sender, EventArgs e)
        {
            Form f2b = new Form(); // senza utilizzare classi
            f2b.Text = "Aperta Form Dinamica";
            f2b.Show(); 
        }
    }
}
