using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

Console.WriteLine("Fun With Async ===>");
await MethodWithProblems(3, 4);
await MethodWithProblemFixed(33, 32);

static async Task MethodWithProblems(int firstParam, int secondParam)
{
    Console.WriteLine("Enter");
    await Task.Run(() =>
    {
        Thread.Sleep(4_000);
        Console.WriteLine("First complete");
        Console.WriteLine("Somthing bad happened");
    });
}


static async Task MethodWithProblemFixed(int firstParam, int secondParam)
{
    Console.WriteLine("Enter");
    if (secondParam < 0)
    {
        Console.WriteLine("Bad data");
        return;
    }

    await actualImplementation();
    async Task actualImplementation()
    {
        await Task.Run(() =>
        {
            Thread.Sleep(4_000);
            Console.WriteLine("First complete");
            Console.WriteLine("Somthing bad happened");
        });
    }
}
