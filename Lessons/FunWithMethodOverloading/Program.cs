using System;
using FunWithMethodOverloading;
using static FunWithMethodOverloading.AddOperations;

Console.WriteLine("***** Fun with Enums *****\n");

EmpTypeEnum emp = EmpTypeEnum.Contractor;
DayOfWeek day = DayOfWeek.Monday;
ConsoleColor cc = ConsoleColor.Gray;

EvaluateEnum(emp);
EvaluateEnum(day);
EvaluateEnum(cc);

static void EvaluateEnum(Enum e)
{
    Console.WriteLine($"=> Information about {e.GetType().Name}");
    Console.WriteLine($"Underlying storage type: {Enum.GetUnderlyingType(e.GetType())}");
    Array enumData = Enum.GetValues(e.GetType());
    Console.WriteLine($"This enum has {enumData.Length} members.");
    for (int i = 0; i < enumData.Length; i++)
    {
        Console.WriteLine($"Name {enumData.GetValue(i)}: {enumData.GetValue(i):D}");
    }
}

enum EmpTypeEnum : byte
{
    Contractor = 1,
    Employee = 2,
    Manager = 3,
    VicePresident = 4
}