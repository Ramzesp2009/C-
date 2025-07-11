using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    internal class PetNameComparer : IComparer
    {
        int IComparer.Compare(object o1, object o2)
        {
            if (o1 is Car car1 && o2 is Car car2)
            {
                return string.Compare(car1.PetName, car2.PetName, StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                throw new ArgumentException("Both objects must be of type Car.");
            }
        }
    }
}
