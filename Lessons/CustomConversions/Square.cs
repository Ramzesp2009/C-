using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    public struct Square
    {
        public int Length { get; set; }
        public Square(int length) : this()
        {
            Length = length;
        }

        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return $"[Length = {Length}]";
        }

        public static explicit operator Square(Rectangle r)
        {
            Square s = new Square { Length = r.Height };
            return s;
        }
    }
}
