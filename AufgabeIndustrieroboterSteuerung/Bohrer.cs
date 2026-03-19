using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeIndustrieroboterSteuerung
{
    internal class Bohrer : Werkzeug
    {
        int groesse;

        public Bohrer(int id, string bezeichner, string art, int verschleiss, int groesse)
            : base(id, bezeichner, art, verschleiss)
        {
            this.groesse = groesse;
        }

        public string Ausgeben()
        {
            return $"Bohrer: ID={id}, Bezeichner={bezeichner}, Art={art}, Verschleiss={verschleiss}, Groesse={groesse}";
        }
    }
}
