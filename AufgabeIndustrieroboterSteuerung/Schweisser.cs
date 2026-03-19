using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeIndustrieroboterSteuerung
{
    internal class Schweisser : Werkzeug
    {
        public override string Ausgeben()
        {
            return $"Schweisser: ID={Id}, Bezeichner={Bezeichner}, Art={Art}, Verschleiss={Verschleiss}";
        }
        public override void Arbeiten()
        {
            Console.WriteLine("Der Schweisser arbeitet.");
            verschleiss += 2;
        }

         public Schweisser(string art, int verschleiss)
             : base(art, verschleiss)
         {
        }
    }
}
