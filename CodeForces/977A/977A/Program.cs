﻿using System;

namespace _977A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            while(k > 0)
            {
                if(n % 10 != 0)
                {
                    n = n - 1;
                }
                else
                {
                    n = n / 10;
                }                
                k--;
            }
            Console.WriteLine(n);
           
            
        }
    }
}
