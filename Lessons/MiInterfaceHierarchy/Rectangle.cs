using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiInterfaceHierarchy
{
    internal class Rectangle : IShape
    {
        public void Draw() => Console.WriteLine("Drawing...");

        public int GetNumberOfSides() => 4;

        public void Print() => Console.WriteLine("Printing...");
    }
}
