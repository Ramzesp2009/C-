using CustomInterface;

Console.WriteLine("***** Fun with Interface *****\n");
IPointy[] myPointObjects = { new Hexagon(), new Knife(), new Triangle(), new Fork(), new PitchFork() };
foreach(IPointy i in myPointObjects)
    Console.WriteLine($"Object has {i.Points} points");