using FunWithLinqExpressions;

Console.WriteLine("***** Fun with Query Exprissions *****\n");

ProductInfo[] itemsInStock = new[]
{
    new ProductInfo { Name = "MacBook Pro", Description = "Apple Laptop", NumberInStock = 5 },
    new ProductInfo { Name = "ThinkPad X1 Carbon", Description = "Lenovo Laptop", NumberInStock = 10 },
    new ProductInfo { Name = "Dell XPS 13", Description = "Dell Laptop", NumberInStock = 0 },
    new ProductInfo { Name = "HP Spectre x360", Description = "HP Laptop", NumberInStock = 2 },
    new ProductInfo { Name = "Asus ZenBook 14", Description = "Asus Laptop", NumberInStock = 4 },
    new ProductInfo { Name = "Acer Swift 3", Description = "Acer Laptop", NumberInStock = 3 }
};

SelectEverything(itemsInStock);
Console.WriteLine();
ListProductNames(itemsInStock);
Console.WriteLine();
GetOverstock(itemsInStock);
Console.WriteLine();
GetNamesAndDescriptions(itemsInStock);
Console.WriteLine();
var subset = GetProjectedSubset(itemsInStock);
foreach (var item in subset)
    Console.WriteLine(item.ToString());
Console.WriteLine();
DisplayDiff();
Console.WriteLine();
DisplayIntersection();
Console.WriteLine();
DisplayConcat();
Console.WriteLine();
DisplayUnion();
Console.WriteLine();
DisplayConcatNoDups();
Console.WriteLine();


static void SelectEverything(ProductInfo[] products)
{
    Console.WriteLine("All product details:");
    var allProducts = from p in products select p;
    foreach (var prod in allProducts)
        Console.WriteLine(prod.ToString());
}

static void ListProductNames(ProductInfo[] products)
{
    Console.WriteLine("Only product names:");
    var names = from p in products select p.Name;
    foreach (var n in names)
       Console.WriteLine(n);
}

static void GetOverstock(ProductInfo[] products)
{
    Console.WriteLine("The overstock items!");
    var overstock = from p in products where p.NumberInStock > 25 select p;

    if (overstock.Any())
    {
        foreach (var c in overstock)
            Console.WriteLine(c.ToString());
    }
    else
    {
        Console.WriteLine("Items weren't found.");
    }
    
}

static void GetNamesAndDescriptions(ProductInfo[] products)
{
    Console.WriteLine("Names and Descriptions:");
    var nameDesc = from p in products select new { p.Name, p.Description };

    foreach (var item in nameDesc)
    {
        Console.WriteLine(item.ToString());
        //Console.WriteLine(item.GetType());
    }
}

static Array GetProjectedSubset(ProductInfo[] products)
{
    var nameDesc = from p in products select new { p.Name, p.Description };
    return nameDesc.ToArray();
}

static void DisplayDiff()
{
    List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
    List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

    var carDiff = (from c in myCars select c).Except(from c2 in yourCars select c2);

    foreach (var car in carDiff)    
        Console.WriteLine(car);
}

static void DisplayIntersection()
{
    List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
    List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

    var carIntersect = (from c in myCars select c).Intersect(from c2 in yourCars select c2);

    foreach (var car in carIntersect)
        Console.WriteLine(car);
}

static void DisplayConcat()
{
    List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
    List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

    var carConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2);

    foreach (var car in carConcat)
        Console.WriteLine(car);
}

static void DisplayUnion()
{
    List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
    List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

    var carUnion = (from c in myCars select c).Union(from c2 in yourCars select c2);

    foreach (var car in carUnion)
        Console.WriteLine(car);
}

static void DisplayConcatNoDups()
{
    List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
    List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };
    var carConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2).Distinct();
    foreach (var car in carConcat)
        Console.WriteLine(car);
}

static void AggregateOps()
{
    double[] winterTemps = { 2.0, 3.5, 1.5, 4.0, -1.0, 0.0, 3.0 };

    Console.WriteLine($"Max temp: {(from t in winterTemps select t).Max()}");

    Console.WriteLine($"Mix temp: {(from t in winterTemps select t).Min()}");

    Console.WriteLine($"Average temp: {(from t in winterTemps select t).Average()}");

    Console.WriteLine($"Sum of all temps: {(from t in winterTemps select t).Sum()}");
}