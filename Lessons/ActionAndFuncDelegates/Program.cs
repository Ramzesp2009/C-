Console.WriteLine("***** Fun with Action and Func *****");

static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
{
    ConsoleColor previous = Console.ForegroundColor;
    Console.ForegroundColor = txtColor;

    for (int i = 0; i < printCount; i++)
    {
        Console.WriteLine(msg);
    }
    Console.ForegroundColor = previous;
}

Action<string, ConsoleColor, int> actionTarget = DisplayMessage;
actionTarget("Action Message!", ConsoleColor.Yellow, 5);


static int Add(int x, int y)
{
    return x + y;
}

static string SumToString(int x, int y)
{
    return (x + y).ToString();
}


Func<int, int, int> funcTarget = Add;

int result = funcTarget.Invoke(40, 40);
Console.WriteLine($"40 + 40 = {result}");

int result2 = Add(40, 40);
Console.WriteLine($"40 + 40 = {result2}");

Func<int, int, string> funcTarget2 = SumToString;

string sum = funcTarget2.Invoke(50, 50);
Console.WriteLine(sum);
string sum2 = funcTarget2.Invoke(50, 50);
Console.WriteLine(sum2);