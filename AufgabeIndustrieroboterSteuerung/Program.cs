namespace AufgabeIndustrieroboterSteuerung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Industrieroboter industrieroboter = new Industrieroboter(1, "IR-1");
            Bohrer bohrer = new Bohrer("Bohrer1", 0, 10);
            Bohrer bohrer2 = new Bohrer("Bohrer2", 0, 10);
            industrieroboter.werkzeugHinzufuegen(5, bohrer);
            industrieroboter.werkzeugHinzufuegen(5, bohrer2);
            industrieroboter.werkzeugHinzufuegen(10, bohrer2);
            industrieroboter.werkzeugHinzufuegen(-1, bohrer2);
            industrieroboter.werkzeugEntfernen(5);
            industrieroboter.werkzeugEntfernen(5);
            industrieroboter.werkzeugEntfernen(10);
            industrieroboter.werkzeugEntfernen(-1);


        }
    }
}
