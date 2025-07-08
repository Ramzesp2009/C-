using Employees;

//CastingExamples();
//static void CastingExamples()
//{
//    object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
//    GivePromotion((Manager)frank);
//    //GivePromotion(frank); // This will not compile, as 'frank' is of type object, not Employee
//    Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
//    GivePromotion(moonUnit);
//    SalesPerson jill = new PtSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
//    GivePromotion(jill);
//}

//static void GivePromotion(Employee emp)
//{
//    Console.WriteLine($"{emp.Name} was promoted");
//    if (emp is SalesPerson s)
//    {
//        Console.WriteLine($"{s.Name} made {s.SalesNumber} sale(s)!");
//    }
//    else if (emp is Manager m)
//    {
//        Console.WriteLine($"{m.Name} had {m.StockOptions}");
//    }
//    else if (emp is var _)
//    {
//        Console.WriteLine($"Unable to promote {emp.Name}. Wrong employee type.");
//    }
//}

static void GivePromotion(Employee emp)
{
    Console.WriteLine($"{emp.Name} was promoted!");
    switch (emp)
    {
        case SalesPerson s when s.SalesNumber > 5:
            Console.WriteLine($"{s.Name} made {s.SalesNumber} sale(s)!");
            break;
        case Manager m:
            Console.WriteLine($"{m.Name} had {m.StockOptions} stock options!");
            break;
        case Employee _:
            Console.WriteLine($"Unable to promote {emp.Name}. Wrong employee type.");
            break;
    }
}

//object[] things = new object[4];
//things[0] = new Hexagon();
//things[1] = false;
//things[2] = new Manager();
//things[3] = "Last thing";
//    foreach (object item in things)
//{
//    Hexagon h = item as Hexagon;
//    if (false == null)
//        Console.WriteLine("Item is not a hexagon");
//    else
//        h.Draw();
//}
