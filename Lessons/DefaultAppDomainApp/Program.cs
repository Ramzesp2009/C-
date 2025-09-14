using System;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Runtime.Loader;


Console.WriteLine("***** Fun with the default AppDomain *****\n");
DisplayDADStats();
Console.WriteLine();
ListAllAssemliesInAppDomain();
Console.WriteLine();
static void DisplayDADStats()
{
    AppDomain defaultAD = AppDomain.CurrentDomain; 
    Console.WriteLine($"Name of this domain: {defaultAD.FriendlyName}");
    Console.WriteLine($"ID of domain in this process: {defaultAD.Id}");
    Console.WriteLine($"Is this the default domain? {defaultAD.IsDefaultAppDomain()}");
    Console.WriteLine($"Base directory of this domain: {defaultAD.BaseDirectory}");
    Console.WriteLine($"Setup information for this domain:");
    Console.WriteLine($"\tApplication Base: {defaultAD.SetupInformation.ApplicationBase}");
    Console.WriteLine($"\tTarget Framework: {defaultAD.SetupInformation.TargetFrameworkName}");
}

static void ListAllAssemliesInAppDomain()
{
    AppDomain defaultAD = AppDomain.CurrentDomain;
    var loadedAssemblies = defaultAD.GetAssemblies().OrderBy(x => x.GetName().Name);

    Console.WriteLine($"***** Here are the assemblies loaded in {defaultAD.FriendlyName} *****");

    loadedAssemblies.ToList().ForEach(a => Console.WriteLine($"-> Name:{a.GetName().Name},\tVersion:{a.GetName().Version}"));
}