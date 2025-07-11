using CustomEnumeratorWithYield;
using System.Collections;

Console.WriteLine("***** Fun with the Yield Keyword *****\n");
Garage carLot = new Garage();
foreach (Car c in carLot)
    Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");
Console.WriteLine();
foreach (Car c in carLot.GetTheCars(true))
    Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");
