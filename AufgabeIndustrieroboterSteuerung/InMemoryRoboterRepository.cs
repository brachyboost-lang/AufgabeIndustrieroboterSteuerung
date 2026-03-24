using AufgabeIndustrieroboterSteuerung.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeIndustrieroboterSteuerung
{
    public class InMemoryRoboterRepository : IRoboterVerwaltung
    {
        Dictionary<int, Industrieroboter> _roboterStore = new();
        public void AddRoboter(Industrieroboter roboter)
        {
            if (_roboterStore.ContainsKey(roboter.Id))
            {
                throw new InvalidOperationException($"Roboter mit dieser ID ({roboter.Id}) existiert bereits.");
            }
            _roboterStore.Add(key: roboter.Id, roboter);
        }

        public Industrieroboter GetRoboterByID(int id)
        {
            return _roboterStore.TryGetValue(id, out var roboter) ? roboter : throw new InvalidOperationException($"Roboter mit dieser ID ({roboter.Id}) existiert nicht.");
        }

        public void UpdateRoboter(Industrieroboter roboter)
        {
            throw new NotImplementedException();
        }
    }
}
