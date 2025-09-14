using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsingEnumerable;

class VeryComplexQueryExpression
{
    public static void QueryStringWithRawDelegates()
    {
        Console.WriteLine("***** Using Raw Delegates *****");

        string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

        Func<string, bool> searchFilter = new Func<string, bool>(Filter);
        Func<string, string> itemToProcess = new Func<string, string>(ProcessItem);

        var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);

        foreach (var s in subset)
            Console.WriteLine($"Item: {s}");
    }
    public static bool Filter(string game)
    {
        return game.Contains(" ");
    }
    public static string ProcessItem(string s)
    {
        return s;
    }
}
