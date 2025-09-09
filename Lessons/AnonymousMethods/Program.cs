using AnonymousMethod;

Console.WriteLine("***** Anonymous Methods *****\n");
int aboutToBlowCoutner = 0;

Car c1 = new Car("SlugBug", 100, 10);
c1.AboutToBlow += static delegate
{
    aboutToBlowCoutner++;
    Console.WriteLine("Eek! Going too fast!");
};

c1.AboutToBlow += delegate
{
    aboutToBlowCoutner++;
    Console.WriteLine($"Message from Car: {c1.msg}");
};

c1.Exploded += delegate
{
    aboutToBlowCoutner++;
    Console.WriteLine($"Fatal Message from Car: {c1.msg}");
};

for (int i = 0; i < 6; i++)
    c1.Accelerate(20);
Console.WriteLine($"AboutToBlowCounter = {aboutToBlowCoutner}");