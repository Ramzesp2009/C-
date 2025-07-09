using System.Collections;
using CustomException;

Console.WriteLine("***** Fum with Custom Exceptions *****\n");
Car myCar = new Car("Rusty", 90);

try
{
        myCar.Accelerate(20);
}
catch (CarIsDeadException e)
{
    Console.WriteLine("\n*** ERROR ***");
    Console.WriteLine($"Message: {e.Message}");
    Console.WriteLine($"ErrorTimeStamp: {e.ErrorTimeStamp}");
    Console.WriteLine($"CauseOfError: {e.CauseOfError}");
}
Console.WriteLine("\n***** Out of exception logic *****\n");