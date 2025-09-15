using System;
using System.Threading;


Console.WriteLine("***** Primary Thread stats *****\n");

Thread primaryThread = Thread.CurrentThread;
primaryThread.Name = "ThePrimaryThread";
Console.WriteLine($"Id of current Thread: {primaryThread.ManagedThreadId}");
Console.WriteLine($"Thread Name: {primaryThread.Name}");
Console.WriteLine($"Has thread started?: {primaryThread.IsAlive}");
Console.WriteLine($"Priority Level: {primaryThread.Priority}");
Console.WriteLine($"Thread State: {primaryThread.ThreadState}");
