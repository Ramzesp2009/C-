using System.IO;

Console.WriteLine("***** The Amazing File Watcher App *****\n");
FileSystemWatcher watcher = new FileSystemWatcher();
try
{
    watcher.Path = @".";
}
catch(ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
    return;
}

watcher.NotifyFilter = NotifyFilters.LastAccess
    | NotifyFilters.LastWrite
    | NotifyFilters.FileName
    | NotifyFilters.DirectoryName;

watcher.Filter = "*.txt";
watcher.Changed += (s, e) => Console.WriteLine($"File: {e.FullPath} {e.ChangeType} {DateTime.UtcNow}");
watcher.Created += (s, e) => Console.WriteLine($"File: {e.FullPath} {e.ChangeType} {DateTime.UtcNow}");
watcher.Deleted += (s, e) => Console.WriteLine($"File: {e.FullPath} {e.ChangeType} {DateTime.UtcNow}");

watcher.Renamed += (s, e) => Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath} {DateTime.UtcNow}");
watcher.EnableRaisingEvents = true;
Console.WriteLine(@"Press 'q' to quit app.");

using (var sw = File.CreateText("TestFile.txt"))
{
    sw.WriteLine("Hello World!");
}

File.Move("TestFile.txt", "TestFile2.txt");
File.Delete("TestFile2.txt");
while (Console.Read() != 'q') ;
