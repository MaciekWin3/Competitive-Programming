using System;

namespace _996A
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int output = 0;
            int one, five, ten, twenty, hundred;
            one = five = ten = twenty = hundred = 0;
            int counter = 0;
            if(input >= 100)
            {
                hundred = input / 100;
                input = input - (hundred * 100);
            }
            if (input >= 20)
            {
                twenty = input / 20;
                input = input - (twenty * 20);
            }
            if (input >= 10)
            {
                ten = input / 10;
                input = input - (ten * 10);
            }
            if (input >= 5)
            {
                five = input / 5;
                input = input - (five * 5);
            }
            if (input >= 1)
            {
                one = input / 1;
                input = input - (one * 1);
            }
            counter = hundred + twenty + five + ten + one;
            Console.WriteLine(counter);
            //Console.ReadKey();
            
        }
    }
}
