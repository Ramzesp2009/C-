using ListOverCollections;
using System.Collections;

Console.WriteLine("*****LINQ over Generic Collections *****\n");


List<Car> myCars = new List<Car>() {
    new Car() { PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW" },
    new Car() { PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
    new Car() { PetName = "Mary", Color = "Red", Speed = 55, Make = "Ford" },
    new Car() { PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
    new Car() { PetName = "Melvin", Color = "White", Speed = 43, Make = "Jeep" },
    new Car() { PetName = "Chucky", Color = "Yellow", Speed = 20, Make = "Volkswagen" },
    new Car() { PetName = "Tiny", Color = "Blue", Speed = 90, Make = "Honda" }
};

GetFastCars(myCars);
Console.WriteLine();
LINQOverArrayList();
Console.WriteLine();
OfTypeAsFilter();

static void GetFastCars(List<Car> myCars)
{
    var fastCars = from c in myCars where c.Speed >= 90 && c.Make == "BMW" select c;
    Console.WriteLine("The following cars are going faster than 55 KM/H:");

    foreach (var car in fastCars)
        Console.WriteLine($"{car.PetName} is going too fast!");
}

static void LINQOverArrayList()
{
    Console.WriteLine("***** LINQ  over Array List *****");

    ArrayList myCars = new ArrayList()
    {
        new Car() { PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW" },
        new Car() { PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
        new Car() { PetName = "Mary", Color = "Red", Speed = 55, Make = "Ford" },
        new Car() { PetName = "Clunker", Color = "Rust", Speed = 5, Make = "SMART" },
        new Car() { PetName = "Melvin", Color = "White", Speed = 43, Make = "Jeep" },
        new Car() { PetName = "Chucky", Color = "Yellow", Speed = 20, Make = "Volkswagen" },
        new Car() { PetName = "Tiny", Color = "Blue", Speed = 90, Make = "Honda" }
    };

    var myCarsEnum = myCars.OfType<Car>();

    var fastCars = from c in myCarsEnum where c.Speed > 55 select c;

    foreach (var car in fastCars)
        Console.WriteLine($"{car.PetName} is going too fast!");
}

static void OfTypeAsFilter()
{
    ArrayList myStuff = new ArrayList();
    myStuff.AddRange(new object[] {10, 400, 8, false, new Car(), "string data" });

    var myInts = myStuff.OfType<int>();
    foreach (var i in myInts)
        Console.WriteLine(i);
}