Console.WriteLine("*****LINQ Return Values *****\n");
IEnumerable<string> subset = GetStringSubset();

Console.WriteLine("GetStringSubset()");
foreach (var item in subset)
{
    Console.WriteLine(item);
}

Console.WriteLine();

Console.WriteLine("GetStringSubsetAsArray()");
foreach (var item in GetStringSubsetAsArray())
{
    Console.WriteLine(item);
}

static IEnumerable<string> GetStringSubset()
{
    string[] colors = {"Light Red", "Green", "Yellow", "Dark Blue", "Dark Red", "Purple", "Orange", "Red", "Dark Green" };

    IEnumerable<string> theRedColors = from c in colors where c.Contains("Red") select c;
    return theRedColors;
}

static string[] GetStringSubsetAsArray()
{
    string[] colors = {"Light RRed", "Green", "Yellow", "Dark Blue", "Dark Red", "Purple", "Orange", "Red", "Dark Green" };

    var theRedColors = from c in colors where c.Contains("Red") select c;

    return theRedColors.ToArray();
}