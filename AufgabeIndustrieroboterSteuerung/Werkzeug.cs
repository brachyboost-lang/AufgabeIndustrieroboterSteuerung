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
        private string art;
        private protected int verschleiss = 0;

        public Werkzeug(int id, string bezeichner, string art)
        {
            this.id = id;
            this.bezeichner = bezeichner;
            this.art = art;
        }
        public abstract string Ausgeben();
        
    }
}
