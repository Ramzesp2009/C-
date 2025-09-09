using GenericPoint;

Console.WriteLine("***** Fun with Generic Structures *****\n");

Point<int> p = new Point<int> (10, 10);
Console.WriteLine($"p.ToString(): {p.ToString()}");
p.ResetPoint();
Console.WriteLine($"p.ToString() after reset: {p.ToString()}");
Console.WriteLine();

Point<double> p2 = new Point<double>(5.4, 3.3);
Console.WriteLine($"p2.ToString(): {p2.ToString()}");
p2.ResetPoint();
Console.WriteLine($"p2.ToString() after reset: {p2.ToString()}");
Console.WriteLine();

Point<string> p3 = new Point<string>("Hello", "World");
Console.WriteLine($"p3.ToString(): {p3.ToString()}");
p3.ResetPoint();
Console.WriteLine($"p3.ToString() after reset: {p3.ToString()}");
Console.WriteLine();

Point<string> p4 = default;
p4.PatternMatching(p4);
Console.WriteLine();

Point<int> p5 = default;

p5.PatternMatching(p5);
Console.WriteLine();