using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double product, sum = 0;

            sum = calc.Add(2, 3);
            Console.WriteLine($"Sum is: {sum}");

            sum = calc.Subtract(2, 3);
            Console.WriteLine($"Sum is: {sum}");

            product = calc.Multiply(2, 3);
            Console.WriteLine($"Product is: {product}");

            product = calc.Power(2, 3);
            Console.WriteLine($"Product is: {product}");

            Console.WriteLine("***** Add() test *****");
            calc.Test(calc.Add(100, 500), 600);
            calc.Test(calc.Add(100, -500.4), -400.4);

            Console.WriteLine("***** Power() test *****");
            calc.Test(calc.Power(100, 3), 1000000);
            Console.ReadKey();

            Console.WriteLine("A little change");

        }
    }
}