using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_Scopa
{
    class Mano
    {
        Mazzo mazzo = new Mazzo();

        public Mano()
        {
            mazzo.MAZZO.Clear();
            MessageBox.Show(mazzo.MAZZO.Count.ToString());
        }

        void Lettura()
        {
            foreach (var item in mazzo.MAZZO)
            {
                MessageBox.Show("Valore: " + item.VALORE.ToString() + "\nSeme: " + item.SEME.ToString());
            }
        }

        void Gioca()
        {

        }
    }
}
