using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeIndustrieroboterSteuerung
{
    internal class Schweisser : Werkzeug
    {
        public void Ausgeben()
        {
            Console.WriteLine($"Schweisser: ID={id}, Bezeichner={bezeichner}, Art={art}, Verschleiss={verschleiss}");
        }
    }
}
