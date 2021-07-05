using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            char nome = new char { };
            char cognome = new char { };

            Console.WriteLine("Nome:" + nome);
            Console.WriteLine("Cognome:" + cognome);

            double n1, n2;
            double Media;

            Console.WriteLine("Inserisce il primo voto" + n1);
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Inserisce il secondo voto" + n2);
            n2 = Convert.ToDouble(Console.ReadLine());

            Media = (n1 + n2) / 2;

            if (Media <= 6)
            {
                Console.WriteLine("Riprovato!");
            }
            else (Media > 7);
            {
                Console.WriteLine("Aprovato!");
            }
            Console.ReadKey();
        }
    }
}
