using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Forms
{
    public class Biblioteca
    {
        public int ID { get; set; }
        public string Autorul { get; set; }
        public string Titlu { get; set; }
        public string Editura { get; set; }
        public DateOnly Anul_Aparitiei { get; set; }
        public int NrPagini { get; set; }
        public Biblioteca(int ID, string autorul, string titlu, string editura, DateOnly anul_Aparitiei, int nrPagini)
        {
            this.ID= ID;
            Autorul = autorul;
            Titlu = titlu;
            Editura = editura;
            Anul_Aparitiei = anul_Aparitiei;
            NrPagini = nrPagini;
        }
    }
}
