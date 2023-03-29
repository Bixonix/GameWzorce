using System;
using System.Collections.Generic;
using System.Text;

namespace GameWzorce
{
    class Przedmiot
    {
        public string Nazwa
        {
            get;
            protected set;
        }
        public string Typ
        {
            get;
            protected set;
        }
        
        public Przedmiot(string nazwa, string typ)
        {
            this.Nazwa = nazwa;
            this.Typ = typ;
            
        }
        public static void WyswietlPrzedmioty(Przedmiot przedmiot)
        {
            Console.WriteLine("Nawa: " + przedmiot.Nazwa + " Typ: " + przedmiot.Typ);
        }
    }
}
