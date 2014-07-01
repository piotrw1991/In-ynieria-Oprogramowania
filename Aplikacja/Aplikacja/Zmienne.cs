using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class Zmienne
    {
        public static byte formularze = 0;
    }
    public class Towar
    {
        protected string nazwa;
        protected string producent;
        protected ulong nrseryjny;
        protected string kategoria;
        protected uint cena;
        protected uint ilosc;
        public Towar(string name, string prod, ulong serialnumber, string category, uint price, uint count)
        {
            nazwa = name;
            producent = prod;
            nrseryjny = serialnumber;
            kategoria = category;
            cena = price;
            ilosc = count;
        }
    }
    public class pracownik
    {
        protected string imie;
        protected string nazwisko;
        protected ulong pesel;
        protected DateTime data_urodzenia;
        public pracownik(string name, string surname, ulong id, DateTime birth)
        {
            imie = name;
            nazwisko = surname;
            pesel = id;
            data_urodzenia = birth;
        }
    }
    public class zamowienie
    {
        protected string sklep;
        protected string towar;
        protected uint ilosc;
        protected string przyjmujacy;
        protected DateTime data_wpisu;
        public zamowienie(string shop, string product, uint count, string who, DateTime when)
        {
            sklep = shop;
            towar = product;
            ilosc = count;
            przyjmujacy = who;
            data_wpisu = when;
        }
    }
}
