using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _935A
{
    class Program
    {
        static void Main(string[] args)
        {
            int output = 0;
            int employees = int.Parse(Console.ReadLine());
            int employeesTmp = employees;
            int leaders = 0;
            while(leaders < employeesTmp/2)
            {
                employees = employees - 1;
                leaders = leaders + 1;
                if(employees % leaders == 0)
                {
                    output++;
                }              
            }
            Console.WriteLine(output);
            
            //Console.ReadKey();

        }
    }
}
