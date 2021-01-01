using System;

namespace _271A
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            input++;
            bool isFound = false;
            int counter = 0;
            while(isFound == false)
            {
                string year = input.ToString();
                counter = 0;
                char[] yearChars = year.ToCharArray();
                Array.Sort(yearChars);
                for(int i = 0; i < year.Length; i++)
                {
                    if(i != year.Length - 1)
                    {
                        if(yearChars[i] != yearChars[i + 1])
                        {
                            counter++;
                        }
                    }
                    else if(yearChars[i - 1] != yearChars[i])
                    {
                        counter++;
                    }
                }

                if(counter == year.Length)
                {
                    isFound = true;
                    Console.WriteLine(year);
                }
                
                input++;
            }
            
        }
    }
}
