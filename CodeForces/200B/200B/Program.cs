using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200B
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile = int.Parse(Console.ReadLine());
            string[] tab = Console.ReadLine().Split(' ');
            int[] intTab = new int[tab.Length];
            decimal sum = tab.Length;
            decimal volume = 0;
            for(int i = 0; i < tab.Length; i++)
            {
                intTab[i] = int.Parse(tab[i]);
                volume = volume + intTab[i];
            }

            decimal output = volume / sum;
            
            
            Console.WriteLine(output);
            //Console.ReadKey();


        }


    }
}
