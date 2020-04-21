using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _236A
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
                      
            string chat = "CHAT WITH HER!";
            string ignore = "IGNORE HIM!";
            string message = Console.ReadLine();
            char[] tab = message.ToCharArray();
            Array.Sort(tab);
            //Console.WriteLine(tab);
            for(int i = 1; i < tab.Length; i++)
            {
                if(tab[i-1] != tab[i])
                {
                    counter++;
                }
            }
            
            
            if(counter % 2 == 0)
            {
                Console.WriteLine(chat);
            }
            else
            {
                Console.WriteLine(ignore);
            }

            //Console.ReadKey();
        }
    }
}
