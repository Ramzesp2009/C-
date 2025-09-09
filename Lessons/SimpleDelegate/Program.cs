using System;
using SimpleDelegate;

Console.WriteLine("***** Simple Delegate Example *****\n");
SimpleMath m = new SimpleMath();
BinaryOp b = new BinaryOp(m.Add);

DisplayDelegateInfo(b);

Console.WriteLine($"10 + 10 is {b(10, 10)}");

static void DisplayDelegateInfo(Delegate delObj)
{
    foreach (Delegate d in delObj.GetInvocationList())
    {
        Console.WriteLine($"Method Name: {d.Method}");
        Console.WriteLine($"Type Name: {d.Target}");
    }
}

public delegate int BinaryOp(int x, int y);
