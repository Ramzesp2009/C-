using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicDelegateProblem
{
    public class Car
    {
        public delegate void CarEngineHandler(string msgForCaller);
        public CarEngineHandler ListOfHandlers;
        public void Accelerate(int delta)
        {
            if (ListOfHandlers != null)
            {
                ListOfHandlers("Sorry, this car is dead...");
            }
        }
    }
}
