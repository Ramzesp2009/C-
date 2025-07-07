using SimpleClassExample;

Console.WriteLine("***** Fun with Class Types *****\n");

Motorcycle c = new Motorcycle(5);
c.SetDriverName("Tiny");
c.PopAWheely();
Console.WriteLine($"Rider name is {c.driverName}");
Motorcycle.PrintDescription();