using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethodOverloading
{
    public static class AddOperations
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static long Add(long x, long y)
        {
            return x + y;
        }
        static int Add(int x, int y, int z = 0)
        {
            return x + (y * z);
        }
        static int Add(ref int x) 
        {
            return 0;
        }
    }
}
