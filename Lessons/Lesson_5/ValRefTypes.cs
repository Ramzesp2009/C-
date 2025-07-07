using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    public struct EvilStruct
    {
        public int X;
        public int Y;

        public PointRef PointRef;
    }
    public struct PointVal
    {
        public int X;
        public int Y;

        public void LogValiues()
        {
            Console.WriteLine($"X={X}, Y={Y}");
        }
    }
    public class PointRef
    {
        public int X;
        public int Y;

        public void LogValiues()
        {
            Console.WriteLine($"X={X}, Y={Y}");
        }
    }
}
