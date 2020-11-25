using System;

namespace _510A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int height = int.Parse(input[0]);
            int length = int.Parse(input[0]);
            string line = "";

            for(int i=0; i<height; i++)
            {
                for(int j=0; j<length; j++)
                {
                    if(i == 0 || i == length - 1)
                    {
                        line = "#" * length;
                    }
                }
            }
        }
    }
}
