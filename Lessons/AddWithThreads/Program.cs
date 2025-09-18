using AddWithThreads;


AutoResetEvent _waitHandle = new AutoResetEvent(false);

Console.WriteLine("***** Adding with Thread objects *****");
Console.WriteLine($"ID of thread in Main(): {Thread.CurrentThread.ManagedThreadId}");
void Add(object data)
{
    if (data is AddParams ap)
    {
        Console.WriteLine($"ID of thread in Add(): {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine($"{ap.a} + {ap.b} = {ap.a + ap.b}");

        _waitHandle.Set();
    }
}

Console.WriteLine($"ID of thread in Main(): {Thread.CurrentThread.ManagedThreadId}");

AddParams ap = new AddParams(10, 10);
Thread t = new Thread(new ParameterizedThreadStart(Add));
t.Start(ap);

_waitHandle.WaitOne();
Console.WriteLine("Other thread is done!");

Thread.Sleep(5);

Console.WriteLine("The end.");