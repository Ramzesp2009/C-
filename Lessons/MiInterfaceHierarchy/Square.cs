using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiInterfaceHierarchy
{
    internal class Square : IShape
    {
        void IPrintable.Draw()
        {
            throw new NotImplementedException();
        }
        void IDrawable.Draw()
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfSides() => 4;

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
