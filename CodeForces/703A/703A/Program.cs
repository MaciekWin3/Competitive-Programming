using System;

namespace _703A
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds = int.Parse(Console.ReadLine());
            int i = 0;
            char[] tab = new char[rounds * 2];
            string tmp;
            while(i < rounds * 2)
            {
                tmp = Console.ReadLine();
                tab[i] = tmp[0];
                tab[i + 1] = tmp[2];
                i = i + 2;
            }
            int[] throws = new int[tab.Length];
            i = 0;
            int mishka = 0;
            int chris = 0;
            while(i < tab.Length)
            {
                throws[i] = Convert.ToInt32(tab[i]);
                i++;
            }           
            i = 0;
            while(i < throws.Length)
            {
                if(throws[i] > throws[i+1])
                {
                    mishka++;
                }
                else if (throws[i] < throws[i+1])
                {
                    chris++;
                }
                else
                {
                    mishka++;
                    chris++;
                }
                i = i + 2;
            }
            if(mishka > chris)
            {
                Console.WriteLine("Mishka");
            }
            else if(mishka < chris)
            {
                Console.WriteLine("Chris");
            }
            else
            {
                Console.WriteLine("Friendship is magic!^^");
            }
            //Console.ReadKey();

        }
    }
}
