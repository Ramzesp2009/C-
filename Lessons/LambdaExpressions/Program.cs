using LambdaExpressions;
using System;
using System.Collections.Generic;

Console.WriteLine("***** Fun with Lambdsa *****\n");
TraditionalDelegateSyntax();
AnonymousMethodSyntax();
LambdaExpressionSyntax();

static void TraditionalDelegateSyntax()
{
    List<int> list = new List<int> { 5, 7, 20, 1, 4, 8, 9, 44 };

    Predicate<int> callback = IsEvenNumber;
    List<int> evenNumbers = list.FindAll(callback);

    Console.WriteLine("Here are your even numbers:");
    foreach (int evenNumber in evenNumbers)
    {
        Console.Write("{0}\t", evenNumber);
    }
    Console.WriteLine();
}

static bool IsEvenNumber(int i)
{
    return (i % 2) == 0;
}

static void AnonymousMethodSyntax()
{
    List<int> list = new List<int> { 5, 7, 20, 1, 4, 8, 9, 44 };

    List<int> evenNumbers = list.FindAll(delegate (int i) { return (i % 2) == 0; });

    Console.WriteLine("Here are your even numbers:");

    foreach (int evenNumber in evenNumbers)
    {
        Console.Write("{0}\t", evenNumber);
    }
    Console.WriteLine();
}

static void LambdaExpressionSyntax()
{
    List<int> list = new List<int> { 5, 7, 20, 1, 4, 8, 9, 44 };
    List<int> evenNumbers = list.FindAll(i =>
    {
        Console.WriteLine($"value of i is vurrently; {i}");
        bool isEven = (i % 2) == 0;
        return isEven;
    });

    Console.WriteLine("Here are your even numbers:");
    foreach (int evenNumber in evenNumbers)
    {
        Console.Write("{0}\t", evenNumber);
    }
}

Console.WriteLine();

SimpleMath m = new SimpleMath();
m.SetMathHandler((msg, result) =>
{
    Console.WriteLine($"Message: {msg}, Result: {result}");
});
m.Add(10, 10);

Console.WriteLine();

var outervAriable = 0;
Func<int, int, bool> DoWork = (x, y) =>
{
    outervAriable++;
    return true;
};
DoWork(3, 4);
Console.WriteLine($"Outer variable now = {outervAriable}");