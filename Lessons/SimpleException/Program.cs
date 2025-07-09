using SimpleException;
using System.Collections;

Console.WriteLine("***** Simple Exception Example *****\n");
Console.WriteLine("=> Creating a car and stepping on it!");
Car myCar = new Car("Zippy", 20);

myCar.CrankTunes(true);
try
{
    for (int i = 0; i < 10; i++)
    {
        myCar.Accelerate(10);
        Console.WriteLine();
    }
}
catch (Exception e)
{
    Console.WriteLine("\n*** ERROR ***");
    Console.WriteLine($"Member name: {e.TargetSite}");
    Console.WriteLine($"Class defining member: {e.TargetSite.DeclaringType}");
    Console.WriteLine($"Member type: {e.TargetSite.MemberType}");
    Console.WriteLine($"Message: {e.Message}");
    Console.WriteLine($"Source: {e.Source}");
    Console.WriteLine($"Stack trace: {e.StackTrace}");
    Console.WriteLine($"Helplink: {e.HelpLink}");
    Console.WriteLine($"\n-> Custom Data:");
    foreach (DictionaryEntry de in e.Data)
    {
        Console.WriteLine($"-> {de.Key}: {de.Value}");
    }
}
Console.WriteLine("\n***** Out of exception logic *****\n");