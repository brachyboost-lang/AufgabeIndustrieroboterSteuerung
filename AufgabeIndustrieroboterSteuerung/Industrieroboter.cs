using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeIndustrieroboterSteuerung
{
    internal class Industrieroboter
    {

        private int id;
        private string bezeichner;
        private static readonly int maxAnzWerkzeuge = 10;

        public Industrieroboter(int id, string bezeichner)
        {
            this.id = id;
            this.bezeichner = bezeichner;
        }

    }
}
