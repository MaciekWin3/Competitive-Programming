using System;

namespace _4A
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int input = int.Parse(a);
            if(input == 2)
            {
                Console.WriteLine("NO");
            }
            else if(input % 2 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
