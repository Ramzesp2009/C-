using CustomGenericMethods1;
using System;

namespace CustomGenericMethods1;

public class MyClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with Custom Generic Methods *****\n");
        int a = 10, b = 90;
        Console.WriteLine($"Before swap: {a}, {b}");
        SwapFunctions.Swap<int>(ref a, ref b);
        Console.WriteLine($"After Swap; {a}, {b}");
        Console.WriteLine();
        string s1 = "Hello", s2 = "There";
        Console.WriteLine($"Before swap: {s1}, {s2}");
        SwapFunctions.Swap<string>(ref s1, ref s2);
        Console.WriteLine($"After Swap; {s1}, {s2}");
        Console.WriteLine();
        bool b1 = true, b2 = false;
        Console.WriteLine($"Before swap: {b1}, {b2}");
        SwapFunctions.Swap(ref b1, ref b2);
        Console.WriteLine($"After swap: {b1}, {b2}");
        Console.ReadLine();
    }
}