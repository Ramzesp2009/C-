using FinalizableDisposableClass1;

Console.WriteLine("***** Dispose() / Destructor Combo Platter *****");
MyResourceWrapper wrapper = new MyResourceWrapper();
wrapper.Dispose();

MyResourceWrapper wrapper2 = new MyResourceWrapper();
Console.ReadLine();