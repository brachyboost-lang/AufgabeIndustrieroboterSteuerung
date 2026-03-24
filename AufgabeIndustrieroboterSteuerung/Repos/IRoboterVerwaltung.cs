using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeIndustrieroboterSteuerung.Repos
{
    public interface IRoboterVerwaltung
    {
        void AddRoboter(Industrieroboter roboter);
        // void RemoveRoboter(Industrieroboter roboter);
        void UpdateRoboter(Industrieroboter roboter);
        Industrieroboter GetRoboterByID(int id);
        // IEnumerable<Industrieroboter> GetAllRoboter();

    }
}
