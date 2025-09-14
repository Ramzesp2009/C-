using System.Diagnostics;


Console.WriteLine("***** Fun with Processes *****\n");
//ListAllRunnuingProcesses();
Console.WriteLine();
//GetSpecificProcess();
Console.WriteLine();
//Main(new string[] { });
Console.WriteLine();
//EnumModsForPid(6024);
Console.WriteLine();
//StartAndKillProcess();
Console.WriteLine();
UseApplicationVerbs();




static void ListAllRunnuingProcesses()
{
    var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;

    foreach (var p in runningProcs)
    {
        string info = $"-> PID: {p.Id}\tName: {p.ProcessName}";
        Console.WriteLine(info);
    }
    Console.WriteLine("*************************************\n");
}

static void GetSpecificProcess()
{
    Process theProc = null;
    try
    {
        theProc = Process.GetProcessById(4);
        Console.WriteLine($"Process Name: {theProc.ProcessName}");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }
}

static void EnumThreadsForPid(int pID)
{
    Process theProc = null;
    try
    {
        theProc = Process.GetProcessById(pID);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }

    Console.WriteLine($"Here are the threads used by: {theProc.ProcessName}");
    ProcessThreadCollection theThreads = theProc.Threads;
    foreach (ProcessThread pt in theThreads)
    {
        string info = $"-> Thread ID: {pt.Id}\tStart Time: {pt.StartTime.ToShortTimeString()}\tPriority:{pt.PriorityLevel}";
        Console.WriteLine(info);
    }
    Console.WriteLine("*******************************************\n");
}

static void Main(string[] args)
{
    Console.WriteLine("***** Enter PID of process to investigate ******");
    Console.WriteLine("PID: ");
    string pID = Console.ReadLine();
    int theProcID = int.Parse(pID);

    EnumThreadsForPid(theProcID);
}

static void EnumModsForPid(int pID)
{
    Process theProc = null;
    try
    {
        theProc = Process.GetProcessById(pID);
    }
    catch(ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }

    Console.WriteLine("Here are the loaded modules for: {0}", theProc.ProcessName);
    ProcessModuleCollection theMods = theProc.Modules;
    foreach(ProcessModule pm in theMods)
    {
        string info = $"-> Module: {pm.ModuleName}\tFile: {pm.FileName}";
        Console.WriteLine(info);
    }
    Console.WriteLine("*******************************************\n");
}

static void StartAndKillProcess()
{
    Process proc = null;
    try
    {
        proc = Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "www.facebook.com");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine($"--> Hit enter to kill {proc.ProcessName}...");

    Thread.Sleep(10000);

    try
    {
        foreach (var p in Process.GetProcessesByName("chrome"))
        {
            p.Kill();
        }
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void UseApplicationVerbs()
{
    int i = 0;
    ProcessStartInfo si = new ProcessStartInfo(@"C:\Users\User\Desktop\Новий Текстовий документ.txt");

    si.Verbs.ToList().ForEach(v => Console.WriteLine(v));
    //foreach (var verb in si.Verbs)
    //{
    //    Console.WriteLine($" {i++}. {verb}");
    //}
    si.WindowStyle = ProcessWindowStyle.Maximized;
    si.Verb = "Edit";
    si.UseShellExecute = true;
    Process.Start(si);
}
