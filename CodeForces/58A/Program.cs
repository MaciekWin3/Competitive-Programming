using System;

namespace _58A
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string hello = "hello";
            int  j = 0;


            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == hello[j])
                {
                    j++;
                    if(j == 5)
                    {
                        break;
                    }
                }
            }
            if(j == 5)
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
