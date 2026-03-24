using System;
using System.Collections.Generic;
using System.Text;
using AufgabeIndustrieroboterSteuerung.Repos;


namespace AufgabeIndustrieroboterSteuerung.Application
{
    public class WerkzeugVerwaltungService
    {
        IRoboterVerwaltung _roboterVerwaltung;
        public WerkzeugVerwaltungService(IRoboterVerwaltung roboterVerwaltung)
        {
            _roboterVerwaltung = roboterVerwaltung;
        }
        public void WerkzeugHinzufuegen(Werkzeug werkzeug, int index, Industrieroboter roboter)
        {
            var roboterFromRepo = _roboterVerwaltung.GetRoboterByID(roboter.Id);

            if (werkzeug == null)
            {
                throw new ArgumentNullException(nameof(werkzeug), "Das Werkzeug darf nicht null sein.");
            }
            if (roboter == null)
            {
                throw new ArgumentNullException(nameof(roboter), "Der Roboter darf nicht null sein.");
            }
            if (index < 0 || index >= Industrieroboter.maxAnzWerkzeuge)
            {
                throw new IndexOutOfRangeException("Index ist außerhalb des gültigen Bereichs.");
            }
            bool success = roboter.werkzeugHinzufuegen(index, werkzeug);
            if (success)
            {
                _roboterVerwaltung.UpdateRoboter(roboter);
            }
        }
    }
}
