using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachWithExtensionMethods
{
    static class GarageExtensionMethods
    {
        public static IEnumerator GetEnumerator(this Garage g)
            => g.CarsInGarage.GetEnumerator();
    }
}
