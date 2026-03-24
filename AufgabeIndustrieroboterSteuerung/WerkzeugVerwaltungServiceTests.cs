using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AufgabeIndustrieroboterSteuerung.Repos;
using AufgabeIndustrieroboterSteuerung.Application;


namespace AufgabeIndustrieroboterSteuerung
{
    public class WerkzeugVerwaltungServiceTests
    {
        [Fact]
        public void Werkzeug()
        {
            IRoboterVerwaltung repo = new InMemoryRoboterVerwaltung();
            var service = new WerkzeugVerwaltungService(repo);
            var roboter = new Industrieroboter { Id = 1 };
            repo.AddRoboter(roboter);

            var bohrer = new Bohrer {"Bohrer 2", 0, 10};
            service.WerkzeugHinzufuegen(bohrer, 0, roboter);
            var updatedRoboter = repo.GetRoboterByID(1);
            Assert.NotNull(updatedRoboter);
            Assert.Equal(bohrer, updatedRoboter.GetWerkzeug(0));
        }
    }
}
