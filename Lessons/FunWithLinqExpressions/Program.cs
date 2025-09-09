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