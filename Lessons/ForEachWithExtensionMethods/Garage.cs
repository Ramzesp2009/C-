using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachWithExtensionMethods
{
    class Garage
    {
        public Car[] CarsInGarage { get; set; }
        public Garage()
        {
            CarsInGarage = new Car[5];
            CarsInGarage[0] = new Car("Zippy", 100);
            CarsInGarage[1] = new Car("Betsy", 50);
            CarsInGarage[2] = new Car("Clunker", 10);
            CarsInGarage[3] = new Car("Speedy", 150);
            CarsInGarage[4] = new Car("Rusty", 20);
        }
    }
}
