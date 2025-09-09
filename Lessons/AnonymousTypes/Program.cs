using System.Drawing;

Console.WriteLine("***** Fun with Anonymous Types *****\n");
var myCar = new { Color = "Bright Pink", Make = "Saab", CurrenSpeed = 55 };
//ReflectOverAnonymousType(myCar);

Console.WriteLine($"My car is a {myCar.Color} {myCar.Make}");

//BuildAnonymousType("Ford", "Red", 100);

static void BuildAnonymousType(string make, string color, int currSp)
{
    var car = new { Make = make, Color = color, Speed = currSp };
    Console.WriteLine($"You have a {car.Color} {car.Make} going {car.Speed}");

    Console.WriteLine($"ToString() == {car.ToString()}");
}

static void ReflectOverAnonymousType(object obj)
{
    Console.WriteLine($"obj is an instance of: {obj.GetType().Name}");
    Console.WriteLine($"Base class of obj: {obj.GetType().BaseType}");
    Console.WriteLine($"obj.ToString() == {obj.ToString()}");
    Console.WriteLine($"obj.GetHashCode() == {obj.GetHashCode()}");
}

static void EqualityTest()
{
    var firstCar = new {Color = "Bright Pink", Make = "Saab", CurrenSpeed = 55};
    var secondCar = new {Color = "Bright Pink", Make = "Saab", CurrenSpeed = 55};
    if (firstCar.Equals(secondCar))
    {
        Console.WriteLine("Same anonymous object!");
    }
    else
    {
        Console.WriteLine("Not the same anonymous object!");
    }

    if (firstCar == secondCar)
    {
        Console.WriteLine("Same anonymous object!");
    }
    else
    {
        Console.WriteLine("Not the same anonymous object!");
    }

    if (firstCar.GetHashCode() == secondCar.GetHashCode())
    {
        Console.WriteLine("Same hash code!");
    }
    else
    {
        Console.WriteLine("Not the same hash code!");
    }

    if (firstCar.GetType().Name == secondCar.GetType().Name)
    {
        Console.WriteLine("Same type!");
    }
    else
    {
        Console.WriteLine("Not the same type!");
    }
    ReflectOverAnonymousType(firstCar);
    ReflectOverAnonymousType(secondCar);
}

EqualityTest();
