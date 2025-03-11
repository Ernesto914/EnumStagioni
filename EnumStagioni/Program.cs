namespace EnumStagioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime Stagione = DateTime.Parse(Console.ReadLine());
            int giornate = Stagione.DayOfYear;
            if (giornate >= 80 || giornate <= 172)
            {
                Console.WriteLine(QuattroStagioni.Primavera);
            }
            else if (giornate >= 172 || giornate <= 265)
            {
                Console.WriteLine(QuattroStagioni.Estate);
            }
            if (giornate > 266 || giornate < 355)
            {
                Console.WriteLine(QuattroStagioni.Autunno);
            }
            else if (giornate >= 355 || giornate <= 79)
            {
                Console.WriteLine(QuattroStagioni.Inverno);
            }
        }

        enum QuattroStagioni                               // Secondo me l'enum è più comodo delle stringhe in questo caso perchè, con l'utilizzo delle stringhe,
        {                                                  // sarebbe molto più complicato ma soprattutto sarebbe difficilmente leggibile e molto più lungo.
            Primavera,
            Estate,
            Autunno,
            Inverno
        }
    }
}
