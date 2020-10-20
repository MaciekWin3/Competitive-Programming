using System;

namespace _282A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int output = 0;

            for(int i = 0; i < n; i++)
            {
                string operation = Console.ReadLine();
                if(operation.Contains('+'))
                {
                    output++;
                }
                else
                {
                    output--;
                }
            }
            Console.WriteLine(output);
        }
    }
}
