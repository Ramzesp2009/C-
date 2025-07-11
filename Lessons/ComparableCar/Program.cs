using ComparableCar;

Console.WriteLine("***** Fun with Object Sorting *****\n");
Car[] myAutos = new Car[5];
myAutos[0] = new Car("Rusty", 80, 123);
myAutos[1] = new Car("Clunker", 55, 456);
myAutos[2] = new Car("Zippy", 100, 789);
myAutos[3] = new Car("Fred", 90, 101);
myAutos[4] = new Car("Mel", 10, 112);
Console.WriteLine("Here is the unordered set of cars:");
foreach(Car c in myAutos)
    Console.WriteLine($"{c.CarID} - {c.PetName}");

Array.Sort(myAutos);
Console.WriteLine();
Console.WriteLine("Here is the ordered set of cars:");
foreach(Car c in myAutos)
    Console.WriteLine($"{c.CarID} - {c.PetName}");

Console.WriteLine();
Array.Sort(myAutos, new PetNameComparer());
Console.WriteLine("Ordering by pet name:");
foreach(Car c in myAutos)
    Console.WriteLine($"{c.CarID} - {c.PetName}");

Console.WriteLine();
Array.Sort(myAutos, Car.SortByPetName);
Console.WriteLine("Ordering by SortByPetName:");
foreach (Car c in myAutos)
    Console.WriteLine($"{c.CarID} - {c.PetName}");