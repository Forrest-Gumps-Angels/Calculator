using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab
{
    public class Calculator : ICalculator
    {
        public Calculator()
        {

        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            if (exp == 1) return x;
            else if (exp == -1) return x;
            else if (exp == 0) return 1;

            if (exp > 0) return x * Power(x, exp - 1);
            else return x / Power(x, exp + 1);

            //return Math.Pow(x, exp);
        }

        public double Divide(double a, double b)
        {
            if (b != 0.0)
                return a / b;
            else
                throw new DivisionException(b);
        }

        public void Test(double methodUT, double expectedResult)
        {
            Console.WriteLine(methodUT == expectedResult ? "Test passed" : "Test failed");
        }

        public void Clear ()
        {
            Accumulator = 0;
        }

        public double Accumulator
        {
            get { return Accumulator; }

            private set { Accumulator = value; }
        }
    }
}