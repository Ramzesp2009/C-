
Console.WriteLine("***** Fun with Tuples! ******");

//static void FillTheseValues(out int x, out string y, out bool z)
//{
//    x = 10;
//    y = "20";
//    z = true;
//}

static (int a, string b, bool c) FillTheseValues()
{
    return (10, "Hallo", true);
}

var samples = FillTheseValues();
Console.WriteLine($"Int is: {samples.a}");
Console.WriteLine($"String is: {samples.b}");
Console.WriteLine($"Boolean is: {samples.c}");