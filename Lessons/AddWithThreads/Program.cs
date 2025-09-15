using AddWithThreads;

Console.WriteLine("***** Adding with Thread objects *****");


static void Add(object data)
{
    if (data is AddParams ap)
    {
        Console.WriteLine($"ID of thread in Add(): {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine($"{ap.a} + {ap.b} = {ap.a + ap.b}");
    }
}

Console.WriteLine($"ID of thread in Main(): {Thread.CurrentThread.ManagedThreadId}");

AddParams ap = new AddParams(10, 10);
Thread t = new Thread(new ParameterizedThreadStart(Add));
t.Start(ap);

Thread.Sleep(5);