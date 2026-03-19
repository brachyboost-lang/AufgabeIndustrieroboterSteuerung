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
            return $"Greifer: ID {Id}, Greifweite={greifweite}, (Art={Art}, Verschleiss={Verschleiss}%) ";
        }
        public override void Arbeiten()
        {
            Console.WriteLine("Der Greifer arbeitet.");
            verschleiss += 1;
        }
        public Greifer(string art, int verschleiss, int greifweite)
            : base(art, verschleiss)
        {
            this.Bezeichner = "Greifer";
            this.greifweite = greifweite;
        }

    }
}
