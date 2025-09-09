using CarEvents;

Console.WriteLine("***** Fun with Events *****\n");
Car c1 = new Car("SlugBug", 100, 10);

c1.AboutToBlow += CarIsAlmostDoomed;
c1.AboutToBlow += CarAboutToBlow;

//Car.CarEngineHandler d = CarExploded;
//c1.Exploded += d;
c1.Exploded += CarExploded;

Console.WriteLine("***** Speeding up *****");
for ( int i = 0; i < 6; i++)
    c1.Accelerate(20);

//c1.Exploded -= d; // Unsubscribe from the event

Console.WriteLine("***** Speeding up *****");
for (int i = 0; i < 6; i++)
    c1.Accelerate(20);

static void CarAboutToBlow(string msg)
{
    Console.WriteLine(msg);
}
static void CarIsAlmostDoomed(string msg)
{
    Console.WriteLine($"=> Critical Message from Car: {msg}");
}
static void CarExploded(string msg)
{
    Console.WriteLine(msg);
}
//static void HookIntoEvents()
//{
//    Car newCar = new Car();
//    newCar.AboutToBlow += NewCarOnAboutToBlow;
//}

//static void NewCarOnAboutToBlow(string msgForCaller)
//{
//    throw new NotImplementedException();
//}