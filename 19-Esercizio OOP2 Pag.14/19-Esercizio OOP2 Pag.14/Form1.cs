using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_Esercizio_OOP2_Pag._14
{
    public partial class Form1 : Form
    {
        // out -> si può passare un parametro non istanziato
        // e istanziarlo successivamente nella funzione
        // la utilizzo quando creo un metodo e voglio consentire
        // all'utente di passare un parametro senza la new

        // ref -> si può passare un parametro già istanziato
        // e non istanziarlo poi nella funzione

        public Form1()
        {
            InitializeComponent();
        }

        public Mostro Clona_V(Mostro p) //rende un Mostro nuovo?
        {
            p = new Mostro("Valuex");
            p.nome = "Cambia";
            return p;
        }

        // in questo caso p è x perchè viene passato per referenza
        // e al termine y non puntera ad un altro mostro ma verrà 
        // direttamente modificato
        public Mostro Clona_R(ref Mostro p)
        {
            p = new Mostro("Referx");
            p.nome = "Cambia";
            return p;
        }

        // con out il mostro non deve essere istanziato, 
        // basta che sia solamente dichiarato, 
        // la new non deve per forza essere già fatta
        public Mostro Clona_O(out Mostro p)
        {
            p = new Mostro("Resulx");
            p.nome = "Cambia";
            return p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mannaro x = new Mannaro();
            Mostro y;
            y = Clona_V(x);
            x.Rivela();
            y.Rivela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mostro x = new Mannaro();
            Mostro y;
            y = Clona_R(ref x);
            x.Rivela();
            y.Rivela();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mostro x/*= new Mannaro()*/;
            Mostro y;
            y = Clona_O(out x);
            x.Rivela();
            y.Rivela();
        }
    }
}
