using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1220A
{
    class Program
    {
        static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }
        static void Main(string[] args)
        {
            int ile = int.Parse(Console.ReadLine());
            string letters = Console.ReadLine();
            string sorted = SortString(letters);
            string output = "";
            int i = 0;
            int z = 0;
            int n = 0;
            while(i < sorted.Length)
            {
                if(sorted[i] == 'z')
                {
                    z++;
                }
                if(sorted[i] == 'n')
                {
                    n++;
                }
                i++;
            }

            i = 0;
            while(i<n)
            {
                output = output + "1 ";
                i++;
            }
            i = 0;
            while(i<z)
            {
               
                output = output + "0 ";
                i++;
            }

            Console.WriteLine(output);
            //Console.ReadKey();

        }
    }
}


