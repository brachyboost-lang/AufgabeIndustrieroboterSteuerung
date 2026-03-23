using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AufgabeIndustrieroboterSteuerung
{
    public static class Werkzeug_xUnittests
    {
        [Theory]
        [InlineData("Bohrer1", 96, 9)]
        [InlineData("Bohrer2", 100, 10)]
        [InlineData("Bohrer3", 99, 11)]
        public static void Werkzeug_Arbeiten_VerschleissGrenze(string art, int verschleiss, int groesse)
        {

            var werkzeug = new Bohrer(art, verschleiss, groesse);
            // Act & Assert
            Assert.Throws<Exception>(() => werkzeug.Arbeiten());
        }

        [Theory]
        [InlineData("Bohrer1", 0, 9)]
        [InlineData("Bohrer2", 95, 10)]
        public static void Werkzeug_Arbeiten_NoException(string art, int verschleiss, int groesse)
        {
            var werkzeug = new Bohrer(art, verschleiss, groesse);
            // Act & Assert
            try
            {
                werkzeug.Arbeiten();
            }
            catch (Exception ex)
            {
                throw new Exception($"Unerwartete Ausnahme: {ex.Message}");
            }
        }

        [Theory]
        [InlineData("Bohrer1", 0, 9)]
        [InlineData("Bohrer2", 50, 10)]
        public static void Werkzeug_Arbeiten_VerschleissErhoeht(string art, int verschleiss, int groesse)
        {
            var werkzeug = new Bohrer(art, verschleiss, groesse);
            // Act
            werkzeug.Arbeiten();
            // Assert
            Assert.Equal(verschleiss + 5, werkzeug.Verschleiss);
        }

        [Theory]
        [InlineData("Bohrer1", 0, 9)]
        [InlineData("Bohrer2", 50, 10)]
        public static void Werkzeug_Arbeiten_VerschleissErhoehtBisGrenze(string art, int verschleiss, int groesse)
        {
            var werkzeug = new Bohrer(art, verschleiss, groesse);
            // Act
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    werkzeug.Arbeiten();
                }
                catch (Exception)
                {
                    break; // Stop if an exception is thrown
                }
            }
            // Assert
            Assert.InRange(werkzeug.Verschleiss, verschleiss, 100);
        }

        [Theory]
        [InlineData("Bohrer1", -1, 9)]
        [InlineData("Bohrer2", 101, 10)]
        public static void Werkzeug_Verschleiss_Setzen_UngueltigeWerte(string art, int verschleiss, int groesse)
        {
            // Arrange & Act & Assert
            Assert.Throws<Exception>(() => new Bohrer(art, verschleiss, groesse));
        }
    }
}
