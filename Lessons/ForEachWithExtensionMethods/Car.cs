using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachWithExtensionMethods
{
    class Car
    {
        public int CurrrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        public Car() { }
        public Car(string petName, int speed)
        {
            PetName = petName;
            CurrrentSpeed = speed;
        }

    }
}
