using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _791A
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] wagi = Console.ReadLine().Split(' ');
            int Limak = int.Parse(wagi[0]);
            int Bob = int.Parse(wagi[1]);
            int i = 0;
            while(Limak <= Bob)
            {
                Bob = Bob * 2;
                Limak = Limak * 3;
                i++;
            }
            //Console.WriteLine(Limak + "  " + Bob);
            Console.WriteLine(i);
            //Console.ReadKey();

        }
    }
}
