using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNongenricCollections
{
    internal class CarCollection : IEnumerable
    {
        private ArrayList arCars = new ArrayList();
        //public CarCollection GetCar(int pos) => (Car)arCars[pos];
        public void AddCar(CarCollection c) => arCars.Add(c);
        public void ClearCars() => arCars.Clear();
        public int Count => arCars.Count;
        IEnumerator IEnumerable.GetEnumerator() => arCars.GetEnumerator();
    }
}
