namespace Functions
{
    internal class Program
    {
        string[] vragen = new string[]
        {
            "What is one of the great values that guides your life?",
            "What's something you wish you'd figured out sooner?",
            "What was your best birthday?",
            "Who was your favorite teacher and why?",
            "What's the story behind one of your scars?"
        };

        internal string GetRandomVraag()
        {
            int random = (Math.(0, 1, 2, 3, 4));
        }
        internal string GetVraag(int vraagIndex)
        {
            return vragen[vraagIndex];
        }
        static void Main(string[] args)
        {
            Program program = new Program(); // er wordt een nieuwe variabele gemaakt: 'program'. dit variabel wordt gebruikt om 'Run' op een specifieke manier uit te voeren
            program.Run(); // de 'Run' functie wordt opgevraagd. de return type is void
        }

        internal void Run(){
            Console.WriteLine("...");
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();
            Vraag6();
            Vraag7();
            string vraag0 = GetVraag(0);
        }

        internal void Vraag1()
        {
            Console.WriteLine("Pancakes or waffles?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag2()
        {
            Console.WriteLine("What is something you can never seem to finish?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag3()
        {
            Console.WriteLine("What's the last book you gave up on and stopped reading?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag4()
        {
            Console.WriteLine("In your group of friends, what role do you play?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag5()
        {
            Console.WriteLine("What's your favorite piece of clothing you own?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag6()
        {
            Console.WriteLine("What have you created that you are most proud of?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal string Vraag7()
        {
            Console.WriteLine("Favorite city?");
            string antwoord = Console.ReadLine();

            return antwoord;
        }
    }
}
