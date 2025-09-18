using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Text;

string _theEBook = "";
GetBook();

Console.WriteLine("Downloading book...");
Console.ReadLine();

void GetBook()
{
    WebClient wc = new WebClient();
    wc.DownloadStringCompleted += (s, eArgs) =>
    {
        _theEBook = eArgs.Result;
        Console.WriteLine("Download complete.");
        GetStats();
    };
    wc.DownloadStringAsync(new Uri("https://www.gutenberg.org/files/1342/1342-0.txt"));
}

void GetStats()
{
    string[] words = _theEBook.Split(new char[] { ' ', '\u000A', '\r', ',', '.', ';', ':', '-', '?', '!' },
        StringSplitOptions.RemoveEmptyEntries);
    //string[] tenMostCommon = FindTenMostCommon(words);
    //string longestWord = FindLongestWord(words);
    string[] tenMostCommon = null;
    string longestWord = string.Empty;

    Parallel.Invoke(
        () =>
        {
            tenMostCommon = FindTenMostCommon(words);
        },
        () =>
        {
            longestWord = FindLongestWord(words);
        });

    StringBuilder bookStats = new StringBuilder("Ten Most Common Words are:\n");
    foreach (string s in tenMostCommon)
    {
        bookStats.AppendLine(s);
    }

    bookStats.AppendFormat($"Longest word is: {longestWord}");
    bookStats.AppendLine();
    Console.WriteLine(bookStats.ToString(), "Book info");
}

string[] FindTenMostCommon(string[] words)
{
    var frequencyOrder = from word in words
                         where word.Length > 6
                         group word by word into g
                         orderby g.Count() descending
                         select g.Key;
    string[] commonWords = (frequencyOrder.Take(10)).ToArray();
    return commonWords;
}

string FindLongestWord(string[] words)
{
    var longestWord = (from w in words
                       orderby w.Length descending
                       select w).FirstOrDefault();
    return longestWord;
}
