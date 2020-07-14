using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,i, fact;
            Console.WriteLine("enter the number:");
            number = Convert.ToInt32(Console.ReadLine());
            fact = number;
            for(i=fact-1;i>=1;i--)
            {
                fact *= i;
            }
            Console.WriteLine("factorial of given number is" + fact);
        }
    }
}
