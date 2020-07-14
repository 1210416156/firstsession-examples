using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.WriteLine("enter 1st number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before exchange number1=" + number1 + "number2=" + number2);
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("after exchange number1=" + number1 + "number2=" + number2);
        }
    }
}
