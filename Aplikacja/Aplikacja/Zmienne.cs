using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class Zmienne
    {
        public static List<Sklep> Sklepy { get; set; }
        public static byte formularze = 0;
        static List<Sklep> sklepy = new List<Sklep>
        { 
            new Sklep("Nazwa1",000001),new Sklep("Nazwa2",000002), new Sklep("Nazwa3",000003) 
        };
    }
}
