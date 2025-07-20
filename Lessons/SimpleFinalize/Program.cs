using System;
using SimpleFinalize;

Console.WriteLine("***** Fun with Finalizers *****'n");
Console.WriteLine("Hit return to create the objects ");
Console.WriteLine("the force the GC to invoke Finalize()");
CreateObjects(1_000_000);
GC.AddMemoryPressure(2147483647);
GC.Collect(0, GCCollectionMode.Forced);
GC.WaitForPendingFinalizers();
Console.ReadLine();

static void CreateObjects(int count)
{
    MyResourceWrapper[] tonsOfObjects = new MyResourceWrapper[count];
    for (int i = 0; i < count; i++)
    {
        tonsOfObjects[i] = new MyResourceWrapper();
    }
    tonsOfObjects = null;
}
