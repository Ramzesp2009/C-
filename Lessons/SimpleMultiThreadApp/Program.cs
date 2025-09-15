using System;
using System.Threading;
using SimpleMultiThreadApp;


Console.WriteLine("***** The Amazing Thread App *****\n");
Console.Write("Do you want [1] or [2] threads? ");
string threadCount = Console.ReadLine();

Thread primaryThread = Thread.CurrentThread;
primaryThread.Name = "Primary";

Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing Main()");

Printer p = new Printer();

switch (threadCount)
{
    case "2":
        Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
        backgroundThread.Name = "Secondary";
        backgroundThread.Start();
        break;
    case "1":
        p.PrintNumbers();
        break;
    default:
        Console.WriteLine("I don't know what you want... you get 1 thread.");
        goto case "1";
}
Console.WriteLine(Thread.CurrentThread.Name);
Console.WriteLine("I'm buse!");
Console.WriteLine("Work on Main Thread...");
