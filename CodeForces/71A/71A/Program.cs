using System;

namespace _71A
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int i = 0;
            string[] output = new string[a];
            while(i < a)
            {
                string input = Console.ReadLine();
                if (input.Length <= 10)
                {
                    output[i] = input;
                }
                else
                {
                    int letters = input.Length - 2;
                    string inside = letters.ToString();
                    output[i] = input[0] + inside + input[input.Length - 1];
                }
                i++;
            }
            i = 0;
            while(i < a)
            {
                Console.WriteLine(output[i]);
                i++;
            }
        }
    }
}
