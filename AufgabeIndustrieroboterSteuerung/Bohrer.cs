using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeIndustrieroboterSteuerung
{
    internal class Bohrer : Werkzeug
    {
        int groesse;

        public Bohrer(string art, int verschleiss, int groesse)
            : base(art, verschleiss)
        {
            this.groesse = groesse;
        }

        public override string Ausgeben()
        {
            return $"Bohrer: ID={Id}, Bezeichner={Bezeichner}, Art={Art}, Verschleiss={Verschleiss}, Groesse={groesse}";
        }
        public override void Arbeiten()
        {
            Console.WriteLine("Der Bohrer arbeitet.");
            verschleiss += 5;
        }
    }
}
