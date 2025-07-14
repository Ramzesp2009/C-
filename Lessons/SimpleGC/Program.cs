using System;
using SimpleGC;

Console.WriteLine("***** Fun with System.GC *****\n");
Console.WriteLine($"Estimated bytes on heap: {GC.GetTotalMemory(false)}");
Console.WriteLine($"This OS has {GC.MaxGeneration + 1} object generations.\n");
Car refToMyCar = new Car("Zippy", 100);
Console.WriteLine(refToMyCar.ToString());
Console.WriteLine($"\nGeneration of refToMyCar is; {GC.GetGeneration(refToMyCar)}");
object[] tonsOfObjects = new object[50000];
for (int i = 0; i < 50000; i++)
    tonsOfObjects[i] = new object();
Console.WriteLine("Force Garbage collection");
GC.Collect(0, GCCollectionMode.Forced);
GC.WaitForPendingFinalizers();
Console.WriteLine($"Generation of refToMyCar is:{GC.GetGeneration(refToMyCar)}");
if (tonsOfObjects[9000] != null)
    Console.WriteLine($"Generation of tonsOfObjects[9000] is: {GC.GetGeneration(tonsOfObjects[9000])}");
else
    Console.WriteLine("tonsOfObject[9000] is no longer olive.");
Console.WriteLine($"\nGen 0 has been swept {GC.CollectionCount(0)} times");
Console.WriteLine($"\nGen 1 has been swept {GC.CollectionCount(1)} times");
Console.WriteLine($"\nGen 2 has been swept {GC.CollectionCount(2)} times");
Console.ReadLine();