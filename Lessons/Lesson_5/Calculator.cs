using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public static class Calculator
    {
        public static bool TryDivide(double divisible, double divisor, out double result)
        {
            result = 0;
            if (divisor == 0)
            {
                return false;
            }
            result = divisible / divisor;
            return true;
        }
        public static double Average(int[] numbers)
        {
            int sum = 0;
            foreach (var i in numbers)
            {
                sum += i;
            }
            return (double)sum / numbers.Length;
        }
        public static double Average2(params int[] numbers)
        {
            int sum = 0;
            foreach (var i in numbers)
            {
                sum += i;
            }
            return (double)sum / numbers.Length;
        }
        public static double CalcTriangleSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public static double CalcTriangleSquare(double b, double h)
        {
            return 0.5 * b * h;
        }
        public static double CalcTriangleSquare(double a, double b, int angle, bool isInRadians = false)
        {
            if (isInRadians)
            {
                return 0.5 * a * b * Math.Sin(angle);
            }
            else
            {
                return 0.5 * a * b * Math.Sin(angle * Math.PI / 180);
            }
        }
    }
}
