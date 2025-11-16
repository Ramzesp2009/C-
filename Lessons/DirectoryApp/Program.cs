Console.WriteLine("***** Fun with Directory(Info) *****\n");
ShowWindowsDirectoryInfo();
//DisplayImageFiles();
ModifyAppDirectory();
FunWithDirectoryType();

static void ShowWindowsDirectoryInfo()
{
    DirectoryInfo dir = new DirectoryInfo($@"C:\\Windows");
    Console.WriteLine("***** Directory Info *****");
    Console.WriteLine($"FullName: {dir.FullName}");
    Console.WriteLine($"Name: {dir.Name}");
    Console.WriteLine($"Parent: {dir.Parent}");
    Console.WriteLine($"Creation: {dir.CreationTimeUtc}");
    Console.WriteLine($"Attributes: {dir.Attributes}");
    Console.WriteLine($"Root: {dir.Root}");
}

static void DisplayImageFiles()
{
    DirectoryInfo dir = new DirectoryInfo("C:\\Users\\User\\Pictures");
    FileInfo[] files = dir.GetFiles("*.png", SearchOption.AllDirectories);
    Console.WriteLine($"Found {files.Length} *.jpg files\n");

    foreach (FileInfo f in files)
    {
        Console.WriteLine("********************************");
        Console.WriteLine($"File Name: {f.Name}");
        Console.WriteLine($"File size: {f.Length}");
        Console.WriteLine($"Creation: {f.CreationTime}");
        Console.WriteLine($"Attributes: {f.Attributes}");
    }
}

static void ModifyAppDirectory()
{
    DirectoryInfo dir = new DirectoryInfo(".");
    dir.CreateSubdirectory("MyFolder");
    DirectoryInfo myDataFoder = dir.CreateSubdirectory(@"MyFolder2\\Data");
    Console.WriteLine($"New Foder is: {myDataFoder}");
}

static void FunWithDirectoryType()
{
    string[] drives = Directory.GetLogicalDrives();
    Console.WriteLine("Here are your drives:");
    foreach (string s in drives)
    {
        Console.WriteLine($"--> {s}");
    }

    Console.WriteLine("Tress Enter to delete directories");
    Console.ReadLine();
    try
    {
        Directory.Delete("MyFolder");
        Directory.Delete("MyFolder2", true);
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
