using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        private bool _carIdDead;
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
                _listOfHandlers?.Invoke("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == (MaxSpeed - CurrentSpeed))
                {
                    _listOfHandlers?.Invoke("Careful buddy! Gonna blow!");
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
        private CarEngineHandler _listOfHandlers;
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            if (_listOfHandlers == null)
                _listOfHandlers += methodToCall;
            else
            {
                _listOfHandlers = Delegate.Combine(_listOfHandlers, methodToCall) as CarEngineHandler;
            }
        }

        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            _listOfHandlers -= methodToCall;
        }
    }
}
