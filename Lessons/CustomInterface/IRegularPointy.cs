using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    interface IRegularPointy : IPointy
    {
        int SideLength { get; set; }
        int NumberOfSides { get; set; }
        int Perimeter => SideLength * NumberOfSides;
        static string ExampleProperty { get; set; }
        static IRegularPointy() => ExampleProperty = "Foo";
    }
}
