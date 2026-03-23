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
            this.Bezeichner = "Bohrer";
            this.groesse = groesse;
        }

        public override string Ausgeben()
        {
            return $"Bohrer mit Groesse {groesse} (Verschleiss {Verschleiss}%)";
        }
        public override void Arbeiten()
        {
            switch (Verschleiss)
            {
                case < 96:
                    Console.WriteLine($"Der {Bezeichner} arbeitet mit Groesse {groesse}.");
                    Verschleiss += 5;
                    break;
                default:
                    throw new Exception("Das Werkzeug ist zu Verschlissen um damit zu Arbeiten.");
            }
        }
    }
}
