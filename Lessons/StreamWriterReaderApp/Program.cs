using System.IO;
using System.Text;

Console.WriteLine("***** Func with StreamWriter / StreamReader *****\n");

using (StreamWriter writer = new StreamWriter("reminders.txt"))
{
    writer.WriteLine("Don't forget Mother's Day this year...");
    writer.WriteLine("Don't forget Father's Day this year...");
    writer.WriteLine("Don't forget these numbers:");
    for (int i = 0; i < 10; i++)
    {
        writer.Write(i + " ");
    }
    writer.Write(writer.NewLine);
}

Console.WriteLine("Created file and wrote some thoughts...");
Console.ReadLine();
//File.Delete("reminders.txt");

Console.WriteLine("***** Fun with StreamWriter / StreamReader *****\n");

Console.WriteLine("Here are your thoughts:\n");
using(StreamReader sr = File.OpenText("reminders.txt"))
{
    string input = null;
    while((input = sr.ReadLine()) != null)
    {
        Console.WriteLine(input);
    }
}