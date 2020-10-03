using System;

namespace _110A
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;

            for(int i=0; i<input.Length; i++)
            {
                if(input[i] == '4' || input[i] == '7')
                {
                    counter++;
                }
            }

            if (counter == 4 || counter == 7)
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
