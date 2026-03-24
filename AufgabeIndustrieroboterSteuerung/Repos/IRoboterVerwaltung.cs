using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeIndustrieroboterSteuerung.Repos
{
    internal interface IRoboterVerwaltung
    {
        void AddRoboter(Industrieroboter roboter);
        // void RemoveRoboter(Industrieroboter roboter);
        void UpdateRoboter(Industrieroboter roboter);
        // void ReadRoboter(Industrieroboter roboter);
        // IEnumerable<Industrieroboter> GetAllRoboter();

    }
}
