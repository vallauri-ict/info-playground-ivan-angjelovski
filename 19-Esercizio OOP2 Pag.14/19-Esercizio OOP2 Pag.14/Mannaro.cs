using System.Windows.Forms;

namespace _19_Esercizio_OOP2_Pag._14
{
    class Mannaro : Mostro
    {
        new public string nome;

        public Mannaro() : base()
        {
            this.nome = "Mannaro";
        }

        public Mannaro(string nome) : base(nome)
        {
            this.nome = "Mannaro" + nome;
        }

        new public void Rivela()
        {
            string s = nome + (char)(32);
            MessageBox.Show(s + base.nome);
        }
    }
}
