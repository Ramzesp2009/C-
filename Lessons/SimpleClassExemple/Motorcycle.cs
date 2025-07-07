using System;
using System.Threading.Channels;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string? driverName;
        public Motorcycle() => Console.WriteLine("In default ctor");
        public Motorcycle(int intensity) : this(intensity, "") => Console.WriteLine("In ctor taking an int");
        public Motorcycle(string name) : this(0, name) => Console.WriteLine("In ctor taking a string");
        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("In master ctor");
            SetInsentsity(intensity);
            driverName = name;
        }

        public void SetInsentsity(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewwww!");
            }
        }
        public void SetDriverName(string name) => driverName = name;
        public static void PrintDescription()
        {
            Console.WriteLine("I'm a Motorcycle!");
        }
    }
}
