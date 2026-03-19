using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeIndustrieroboterSteuerung
{
    internal class Greifer : Werkzeug
    {
        int greifweite;

        public override string Ausgeben()
        {
            return $"Greifer: ID{Id}, Bezeichner={Bezeichner}, Art={Art}, Verschleiss={Verschleiss}, Greifweite={greifweite}";
        }
        public override void Arbeiten()
        {
            Console.WriteLine("Der Greifer arbeitet.");
            verschleiss += 1;
        }
        public Greifer(string art, int verschleiss, int greifweite)
            : base(art, verschleiss)
        {
            this.greifweite = greifweite;
        }

    }
}
