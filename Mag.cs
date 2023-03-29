using System;
using System.Collections.Generic;
using System.Text;

namespace GameWzorce
{
    class Mag : Klasa
    {


        //public Mag(string nazwa, int mana, int zycie)
        //{
        //    this.Nazwa = nazwa;
        //    this.Mana = mana;
        //    this.Zycie = zycie;
        //    this.Profesja = "Mag";
        //    mana = 100;
        //    zycie = 100;
        //}
        public Mag(string nazwa/*, int mana, int zycie*/)
        {
            this.Nazwa = nazwa;
            //this.Mana = mana;
            this.Profesja = "Wojownik";
            //this.Zycie = zycie;
            this.Mana = 0;
            this.Zycie = 200;

        }
        public static void Atack(Rozdzka rozdzka)
            {
                Atak_Magiczny(rozdzka);
            }
        public static void Atak_Magiczny(Rozdzka rozdzka)
        {
            Console.WriteLine("Atak magiczny " + rozdzka.Obrazenia);
        }
        public void Wyswietl()
        {
            Console.WriteLine("Nick : " + Nazwa + ", Profesja : " + Profesja + ", Zycie: " + Zycie + ", Mana: " + Mana);
        }

    }
}
