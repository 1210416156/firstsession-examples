using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
			int number1, number2, number3;
			Console.WriteLine("enter 1st number :");
			number1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("enter 2nd number :");
			number2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("enter 3rd number :");
			number3 = Convert.ToInt32(Console.ReadLine());
			if (number1 > number2)
			{
				if (number1 > number3)
					Console.WriteLine("Number 1 is the largest");
				else
					Console.WriteLine("Number 3 is the largest");
			}
			else if (number2 > number3)
				Console.WriteLine("Number 2 is greater");
			else
				Console.WriteLine("Number 3 is greater");
		}
    }
}
