using System;
using System.Linq;

namespace _59A
{
    class Program
    {
        static void Main(string[] args)
        {

            int counterUpper = 0;
            int counterLower = 0;

            string input = Console.ReadLine();
            for(int i = 0; i < input.Length; i++)
            {
                if (Char.IsUpper(input[i]) == true)
                {
                    counterUpper++;
                }
                else
                {
                    counterLower++;
                }
            }
            if(counterUpper > counterLower)
            {
                Console.WriteLine(input.ToUpper());
            }
            else
            {
                Console.WriteLine(input.ToLower());
            }
        }
    }
}
