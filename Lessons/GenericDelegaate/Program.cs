Console.WriteLine("***** Generic Delegates *****\n");
MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
strTarget("Some string data");

MyGenericDelegate<int> intTarget = IntTarget;
intTarget(9);

static void StringTarget(string arg)
{
    Console.WriteLine($"arg in uppercase is; {arg.ToUpper()}");
}

static void IntTarget(int arg)
{
    Console.WriteLine($"++arg is: {++arg}");
}

public delegate void MyGenericDelegate<T>(T arg);