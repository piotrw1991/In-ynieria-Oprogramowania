using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class Sklep
    {
        protected string Nazwa { get; set; }
        protected int NIP { get; set; }

        public Sklep(string name, int nip)
        {
            Zmienne.Sklepy = new List<Sklep>();
            Nazwa = name;
            NIP = nip;
        }
        
       

    }


}
