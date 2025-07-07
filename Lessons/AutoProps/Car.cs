using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    internal class Car
    {
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Car Info: {PetName}, Speed: {Speed}, Color: {Color}");
        }
        public Car()
        {
            PetName = "Default";
            Speed = 0;
            Color = "Unknown";
        }
        public Car(string petName, int speed, string color)
        {
            PetName = petName;
            Speed = speed;
            Color = color;
        }
    }
}
