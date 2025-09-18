Console.WriteLine("***** Working with Timer type *****\n");
TimerCallback timeCB = new TimerCallback(PrintTime);

var _ = new Timer(timeCB, null, 0, 1000);
Console.WriteLine("Hit keey to terminate...");
Console.ReadLine();
static void PrintTime(object state)
{
    Console.WriteLine($"Time is: {DateTime.Now.ToLongTimeString()}");
}
