using System;
using System.Collections.Generic;
using System.Text;

namespace GameWzorce
{
    class Bron:Przedmiot
    {
        public Bron(string nazwa, string typ) : base(nazwa, typ)
        {
            
        }
        
        public int Obrazenia
        {
            get;
            protected set;
        }
            
    }
}
