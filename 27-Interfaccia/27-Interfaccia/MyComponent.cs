
using System.Windows.Forms;

namespace _27_Interfaccia
{
    class MyComponent : IDispAggiuntivo
    {
        private int _id = 0;
        private bool _status;

        public int id { get => _id; set => _id = value; }

        public bool status => _status;

        public void connetti(string s)
        {
            _status = true;
            MessageBox.Show("Connesso a: " + s);
        }

        public void disconnetti(string s)
        {
            _status = false;
            MessageBox.Show("Disconnesso da: " + s);
        }

        public void stato()
        {
            if (status)
            {
                MessageBox.Show("Attualmente Connesso con ID: " + id);
            }
            else
            {
                MessageBox.Show("Non Connesso");
            }
        }
    }
}
