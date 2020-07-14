using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,sum=0;
            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            while(number>0)
            {
                sum+=(number % 10);
                number /= 10;
            }
            Console.WriteLine("sum is =" + sum);
        }
    }
}
