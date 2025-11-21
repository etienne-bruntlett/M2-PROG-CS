namespace Functions
{
    internal class Program{
        static void Main(string[] args)
        {
            Program program = new Program(); // er wordt een nieuwe variabele gemaakt: 'program'. dit variabel wordt gebruikt om 'Run' op een specifieke manier uit te voeren
            program.Run(); // de 'Run' functie wordt opgevraagd. de return type is void
        }

        void Run(){
            Console.WriteLine("Dit is de start van mijn programma.");
        }
    }
}
