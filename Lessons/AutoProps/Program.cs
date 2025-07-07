using AutoProps;

Console.WriteLine("***** Fun with Automatic Properties *****\n");
Car c = new Car();
c.PetName = "Frank";
c.Speed = 55;
c.Color = "Red";
c.DisplayInfo();

Garage g = new Garage();
g.MyAuto = c;
Console.WriteLine($"Number of Cars in garage: {g.NumberOfCars}");
Console.WriteLine($"Your car is named: {g.MyAuto.PetName}");