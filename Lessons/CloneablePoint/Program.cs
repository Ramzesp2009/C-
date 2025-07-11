using CloneablePoint;

Console.WriteLine("***** Fun with Object Cloning *****\n");
Point p1 = new Point(50, 50);
Point p2 = (Point)p1.Clone();
p2.X = 0;
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine($"p1 referenceEquals p2: {ReferenceEquals(p1, p2)}");
Console.WriteLine($"p1 equals p2: {p1.Equals(p2)}");
Console.WriteLine($"p1 == p2: {p1 == p2}");
Console.WriteLine();

Point p3 = new Point(50, 50);
Point p4 = p3;
p4.X = 0;
Console.WriteLine($"p1: {p3}");
Console.WriteLine($"p2: {p4}");
Console.WriteLine($"p1 referenceEquals p2: {ReferenceEquals(p3, p4)}");  // має бути True
Console.WriteLine($"p1 equals p2: {p3.Equals(p4)}");
Console.WriteLine($"p1 == p2: {p3 == p4}");
Console.WriteLine();

Point p5 = new Point(100, 100, "Jane");
Point p6 = (Point)p5.Clone();
Console.WriteLine("Before modification:");
Console.WriteLine($"p5: {p5}");
Console.WriteLine($"p6: {p6}");

p6.desc.PetName = "My new Point";
p6.X = 9;
Console.WriteLine("\nChanged p6.desc.PetName and p6.X");
Console.WriteLine("After modification:");
Console.WriteLine($"p5: {p5}");
Console.WriteLine($"p6: {p6}");