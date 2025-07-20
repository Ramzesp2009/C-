namespace SimpleDispose;

class MyResourceWrapper : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("***** IN DISPOSE *****");
    }
    public static void UsingDeclaration()
    {
        using var resource = new MyResourceWrapper();
        // Do something with the resource
        Console.WriteLine("About to dispose.");
    }
}