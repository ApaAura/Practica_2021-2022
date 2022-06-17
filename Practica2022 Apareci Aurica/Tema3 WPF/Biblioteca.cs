using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_WPF
{
    public class Biblioteca
    {
        public int ID { get; set; }
        public string Autorul { get; set; }
        public string Titlu { get; set; }
        public string Editura { get; set; }
        public DateTime Anul_Aparitiei { get; set; }
        public int NrPagini { get; set; }
        public Biblioteca(int iD, string autorul, string titlu, string editura, DateTime anul_Aparitiei, int nrPagini)
        {
            ID = iD;
            Autorul = autorul;
            Titlu = titlu;
            Editura = editura;
            Anul_Aparitiei = anul_Aparitiei;
            NrPagini = nrPagini;
        }

        public Biblioteca()
        {
            ID = 0;
            Autorul = "";
            Titlu = "";
            Editura = "";
            Anul_Aparitiei = DateTime.Now;
            NrPagini = 0;
        }
    }
}
