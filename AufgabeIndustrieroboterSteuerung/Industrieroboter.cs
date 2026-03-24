using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeIndustrieroboterSteuerung
{
    public class Industrieroboter
    {

        private int id;
        public int Id { get => id; init; }
        private string bezeichner;
        internal static readonly int maxAnzWerkzeuge = 10;
        Werkzeug[] Werkzeugkasten = new Werkzeug[Industrieroboter.maxAnzWerkzeuge];

        public Industrieroboter(int id, string bezeichner)
        {
            this.id = id;
            this.bezeichner = bezeichner;
        }
        public bool werkzeugHinzufuegen(int index, Werkzeug neu)
        {
          try {
                if (index < 0 || index >= Industrieroboter.maxAnzWerkzeuge)
                {
                    throw new IndexOutOfRangeException("Index ist außerhalb des gültigen Bereichs.");
                }
                if (neu == null)
                {
                    throw new ArgumentNullException(nameof(neu), "Das Werkzeug darf nicht null sein.");
                }
                if (Werkzeugkasten[index] != null)
                {
                    throw new InvalidOperationException("Der Platz ist bereits belegt.");
                }
                Werkzeugkasten[index] = neu;
                Console.WriteLine($"{neu.Ausgeben()} wurde Platz {index} zugewiesen.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Hinzufügen des Werkzeugs: {ex.Message}");
                return false;
            }
        }
        public bool werkzeugEntfernen(int index)
        {
         try {
                if (index < 0 || index >= Industrieroboter.maxAnzWerkzeuge)
                {
                    throw new IndexOutOfRangeException("Index ist außerhalb des gültigen Bereichs.");
                }
                if (Werkzeugkasten[index] == null)
                {
                    throw new InvalidOperationException("Der Platz ist bereits leer.");
                }
                Console.WriteLine($"{Werkzeugkasten[index].Ausgeben()} auf Platz {index} wurde entfernt.");
                Werkzeugkasten[index] = null;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Entfernen des Werkzeugs: {ex.Message}");
                return false;
            }
        }
         public Werkzeug GetWerkzeug(int index)
        {
            Werkzeug werkzeug = Werkzeugkasten[index];
            return werkzeug;
        }
        public int findeWerkzeug(Werkzeug w)
        {
            if (w == null)
            {
                return -1;
            }
            return w.Id;
        }
        public List<int> freiePlaetze()
        {
            List<int> freiePlaetze = new List<int>();
            for (int i = 0; i < Werkzeugkasten.Length; i++)
            {
                if (Werkzeugkasten[i] == null)
                {
                    freiePlaetze.Add(i);
                }
            }
            return freiePlaetze;


        }

    }
}
