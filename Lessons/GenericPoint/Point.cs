using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    public struct Point<T>
    {
        private T _xPos;
        private T _yPos;

        public Point (T xVal, T yVal)
        {
            _xPos = xVal;
            _yPos = yVal;
        }
        public T X
        {
            get => _xPos;
            set => _xPos = value;
        }
        public T Y
        {
            get => _yPos;
            set => _yPos = value;
        }
        public override string ToString() => $"[{_xPos}, {_yPos}]";

        public void ResetPoint()
        {
            _xPos = default;
            _yPos = default;
        }

        public void PatternMatching<T>(Point<T> p)
        {
            switch (p)
            {
                case Point<string> pStr:
                    Console.WriteLine("Point is based on strings");
                    return;
                case Point<int> pInt:
                    Console.WriteLine("Point is based on ints");
                    return;
            }
        }
    }
}
