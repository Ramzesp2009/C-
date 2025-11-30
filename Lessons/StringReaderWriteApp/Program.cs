using System.Text;

Console.WriteLine("***** Fun with StringWriter / StringReader ******\n");

using StringWriter strWriter = new StringWriter();

strWriter.WriteLine("Don't forget Mother's Day this year...");

Console.WriteLine($"Contents of StringWriter:\n{strWriter}");

StringBuilder sb = strWriter.GetStringBuilder();
sb.Insert(0, "Hey!! ");
Console.WriteLine($"-> {sb.ToString()}");
sb.Remove(0, "Hey!! ".Length);
Console.WriteLine($"-> {sb.ToString()}");
