using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    public class FunWithMethods
    {
        public int Addition(int x, int y)
        {
            int ans = x + y;
            x = 10000;
            y = 88888;
            return ans;
        }
        public int Addition2(in int x, in int y)
        {
            //x = 10000; // This change won't affect the caller
            //y = 88888; // This change won't affect the caller
            int ans = x + y;
            return ans;
        }
        public double CalculateAverage(params double[] values)
        {
            Console.WriteLine($"You sent me {values.Length} doubles.");
            double sum = 0;
            if (values.Length < 0)
            {
                return sum;
            }
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return (sum / values.Length);
        }
        public void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine($"Error: {message}");
            Console.WriteLine($"Owner of Error: {owner}");
        }
        
    }
}
