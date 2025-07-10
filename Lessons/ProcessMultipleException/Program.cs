using System.Diagnostics.CodeAnalysis;
using ProcessMultipleException;

Console.WriteLine("***** Handling Multiple Exceptions *****\n");
Car myCar = new Car("Rusty", 90);
try
{
    myCar.Accelerate(-10);
}
catch (CarIsDeadException e)
    when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
    {
        Console.WriteLine("Catching car is dead.");
        Console.WriteLine(e.Message);
    }
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
//catch
//{
//    Console.WriteLine("Something is wrong.");
//}
finally
{
    myCar.CrankTunes(false);
}