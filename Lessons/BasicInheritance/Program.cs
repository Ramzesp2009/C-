using BasicInheritance;

Console.WriteLine("***** Basec Inheritance *****\n");
Car myCar = new Car(80) { Speed = 50 };
Console.WriteLine($"My car is going {myCar.Speed} MPH");

MiniVan myVan = new MiniVan { Speed = 10 };
Console.WriteLine($"My van is going {myVan.Speed} MPH");
