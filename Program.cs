namespace LoopsMoodle
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Oppgave 1");
            Console.WriteLine("");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Terje er Kul");
            }

            Console.WriteLine("");
            Console.WriteLine("Oppgave 2");
            Console.WriteLine("");
            string[] foreachloops = new string[] { "F", "O", "R", "E", "A", "C", "H", "-", "L", "O", "O", "P" };
            foreach (var arg in foreachloops)
            {
                Console.WriteLine(arg);
            }
            Console.WriteLine("");
            Console.WriteLine("Oppgave 3");
            Console.WriteLine("");

            Boolean EndLoop = true;
            int Index = 0;
            while (true)
            {
                if (Index < 11)
                {
                    Console.WriteLine("Runde Nummer " + Index);
                    Index++;
                }
                else
                {
                    EndLoop = false;
                }
            }

        }
    }
}
