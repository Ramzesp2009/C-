static async IAsyncEnumerable<int> GenerateSequence()
{
    for (int i = 0; i < 20; i++)
    {
        await Task.Delay(100);
        yield return i;
    }
}

await foreach (var number in GenerateSequence())
{
    Console.WriteLine(number);
}
