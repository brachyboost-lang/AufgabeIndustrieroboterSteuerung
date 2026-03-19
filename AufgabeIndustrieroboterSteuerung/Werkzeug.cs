using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeIndustrieroboterSteuerung
{
    internal abstract class Werkzeug 
    {
        private int id;
        public int Id { get => id; set { id = value;} }
        private string bezeichner;
        public string Bezeichner { get => bezeichner; set { bezeichner = value;} }
        public string Art { get; set { field = value;} }
        private protected int verschleiss = 0;
        public int Verschleiss { get => verschleiss; set { verschleiss = value;} }

        public Werkzeug(string art, int verschleiss)
        {
            this.Art = Art;
            this.verschleiss = Verschleiss;
        }
        public abstract string Ausgeben();
        public abstract void Arbeiten();
        
    }
}
