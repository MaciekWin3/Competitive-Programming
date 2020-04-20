using System;

namespace CodeForces
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile = int.Parse(Console.ReadLine());
            string[] tablica = Console.ReadLine().Split(' ');
            bool trudne = false;
            int i = 0;
            while (i < ile)
            {
                if (tablica[i] == "1")
                {
                    trudne = true;
                    break;
                }
                i++;
            }
            if (trudne)
            {
                Console.WriteLine("HARD");
            }
            else
            {
                Console.WriteLine("EASY");
            }

        }
    }
}

