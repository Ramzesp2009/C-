using ForEachWithExtensionMethods;

Console.WriteLine("***** Support for Extensions Method GetEnumerator *****\n");
Garage carLot = new Garage();
foreach (Car c in carLot)
{
    Console.WriteLine($"{c.PetName} is going {c.CurrrentSpeed}");
}
