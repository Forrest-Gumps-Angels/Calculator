using System;

namespace CalculatorLab
{
    public class DivisionException : Exception
    {
        public double B { get; private set; }
        public DivisionException(double b)
        {
            B = b;
        }
    }
}