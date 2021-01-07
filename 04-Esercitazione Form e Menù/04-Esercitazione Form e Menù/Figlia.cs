using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Esercitazione_Form_e_Menù
{
    public partial class Figlia : Form
    {
        public Figlia(TextBox txtForm1)
        {
            InitializeComponent();
            txtFiglia.Text = txtForm1.Text;
        }
    }
}
