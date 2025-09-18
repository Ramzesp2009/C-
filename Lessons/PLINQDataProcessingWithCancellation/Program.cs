using System;   
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

CancellationTokenSource _cancelToken = new CancellationTokenSource();

do
{
    Console.WriteLine("Press any key to start processing");
    Console.ReadKey();
    Console.WriteLine("Processing");
    Task.Factory.StartNew(ProcessIntData);
    Console.Write("Enter Q to quiit: ");
    string answer = Console.ReadLine();

    if (answer.Equals("Q", StringComparison.OrdinalIgnoreCase))
    {
        _cancelToken.Cancel();
        break;
    }
}
while (true);
Console.ReadLine();

void ProcessIntData()
{
    int[] source = Enumerable.Range(1, 100_000_000).ToArray();
    int[] modThreeIsZero = null;

    try
    {
        modThreeIsZero = (from num in source.AsParallel().WithCancellation(_cancelToken.Token)
                          where num % 3 == 0
                          orderby num descending
                          select num).ToArray();
        Console.WriteLine();

        Console.WriteLine($"Found {modThreeIsZero.Count()} numbers that match query!");
    }
    catch (OperationCanceledException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
