using CustomEnumerator;


Console.WriteLine("***** Fun with IEnumerable / IEnumerator *****\n");
Garage carLot = new Garage();
foreach (Car c in carLot)
{
    Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH.");
}
