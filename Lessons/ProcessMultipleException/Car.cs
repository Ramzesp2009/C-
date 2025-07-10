using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using ProcessMultipleException;

namespace ProcessMultipleException
{
    internal class Car
    {
        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        private bool _carIsDead;
        private readonly Radio _theMusicBox = new Radio();
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public void CrankTunes(bool state)
        {
            _theMusicBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            if (delta < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(delta), "Speed must be greater than zero.");
            }
            if (_carIsDead)
            {
                Console.WriteLine($"{PetName} is out of order...");
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    Console.WriteLine($"{PetName} has overheated!");
                    CurrentSpeed = 0;
                    _carIsDead = true;
                    throw new CarIsDeadException("You have a lead foot!", DateTime.Now, $"{PetName} has overheated!")
                    {
                        HelpLink = "http://www.cars.com/overheated",
                        //Data =
                        //{
                        //    {"TimeStamp",$"The car exploded at {DateTime.Now}" },
                        //    {"Cause",},
                        //}
                    };
                }
                else
                {
                    Console.WriteLine($"=> CurrentSpeed = {CurrentSpeed}");
                }
            }
        }
    }
}
