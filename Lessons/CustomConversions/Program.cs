using CustomConversions;

Console.WriteLine("***** Fun with Conversions *****\n");
Rectangle r = new Rectangle(10, 5);
Console.WriteLine(r.ToString());
r.Draw();
Console.WriteLine();
Square s = (Square)r; // Explicit conversion from Rectangle to Square
Console.WriteLine(s.ToString());
s.Draw();

Square s3 = new Square { Length = 7 };
Rectangle rect2 = s3; // Implicit conversion from Square to Rectangle
Console.WriteLine($"rect2 = {rect2}");
Square s4 = new Square { Length = 4 };
Rectangle rect3 = (Rectangle)s4; // Explicit conversion from Square to Rectangle
Console.WriteLine($"rect3 = {rect3}");
