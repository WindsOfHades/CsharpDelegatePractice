using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesPractice
{
    class Calculation
    {
        public static double Add(double x, double y)
        {
            double result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
            return result;
        }
        public static double Sub(double x, double y)
        {
            double result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
            return result;
        }
        public static double Multiply(double x, double y)
        {
            double result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
            return result;
        }
        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Division by zero is not allowed!");
                return 0;
            }
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
            return result;
        }
    }
}
