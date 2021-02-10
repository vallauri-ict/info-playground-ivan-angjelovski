using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Stagisti
{
    class clsAlunno : clsPersona
    {
        #region attributi 
        private static int progressivo = 0;
        private readonly string matricola;
        private char classe;
        private char sezione;
        private string specializzazione;
        #endregion

        #region properties 
        public int Progressivo { get => progressivo; set => progressivo = value; }
        public string Matricola => matricola;
        public char Sezione { get => sezione; set => sezione = value; }
        public char Classe { get => classe; set => classe = value; }
        public string Specializzazione { get => specializzazione; set => specializzazione = value; }
        #endregion

    }
}
