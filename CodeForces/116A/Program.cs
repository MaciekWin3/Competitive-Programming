using System;

namespace _116A
{
    class Program
    {
        static void Main(string[] args)
        {
            int stops = int.Parse(Console.ReadLine());
            int capacity = 0;
            int max = 0;

            for(int i = 0; i < stops; i++)
            {
                string [] passangers = Console.ReadLine().Split(" ");
                int exit = int.Parse(passangers[0]); 
                int enter = int.Parse(passangers[1]); 
                if(i == 0)
                {
                    capacity = exit;
                }
                capacity = capacity - exit + enter;
                if(capacity > max)
                {
                    max = capacity;
                }

            }
            Console.WriteLine(max);
        }
    }
}
