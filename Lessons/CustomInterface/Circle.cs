using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    internal class Circle : Shape//, IDraw3D
    {
        public Circle() { }
        public Circle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Circle");
        }
        //public void Draw3D() => Console.WriteLine("Drawing Circle in 3D!");
    }
}
