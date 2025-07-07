using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    internal class MyMathClass
    {
        public static readonly double PI;
        static MyMathClass()
        {
            PI = 3.14159; // This is a constant value for PI
        }
    }
}
