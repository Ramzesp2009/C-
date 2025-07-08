using RecordInheritance;

//Console.WriteLine("***** Record Typing Inheritance *****\n");
//Car c = new Car("Honda", "Pilot", "Blue");
//MiniVan m = new MiniVan("Honda", "Odyssey", "Blue", 10);
//Console.WriteLine($"Checking MiniVan is-a Car: {m is Car}");
//Console.WriteLine("---------------------------------");
//PositionalCar pc = new PositionalCar("Honda", "Pilot", "Blue");
//PositionalMiniVan pm = new PositionalMiniVan("Honda", "Odyssey", "Blue");
//Console.WriteLine($"Checking PositionalMiniVAn is-a PositionalCar: {pm is PositionalCar}");

MotorCycle mc = new MotorCycle("Harley", "Lowrider");
Scooter sc = new Scooter("Harley", "Lowrider");
Console.WriteLine($"MotorCycle and Scooter are equal:{Equals(mc, sc)}");
public record MotorCycle(string Make, string Model);
public record Scooter(string Make, string Model) : MotorCycle(Make, Model);

