using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        private bool _carIdDead;

        private CarEngineHandler _listOfHandlers;

        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        public void Accelerate(int delta)
        {
            if (_carIdDead)
            {
                Exploded?.Invoke("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == (MaxSpeed - CurrentSpeed))
                {
                    AboutToBlow?.Invoke("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                {
                    _carIdDead = true;
                }
                else
                {
                    Console.WriteLine($"Current speed is {CurrentSpeed}");
                }
            }
        }


        public delegate void CarEngineHandler(string msgForCaller);
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;
    }
}
