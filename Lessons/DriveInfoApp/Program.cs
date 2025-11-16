DriveInfo[] myDrives = DriveInfo.GetDrives();

foreach (DriveInfo d in myDrives)
{
    Console.WriteLine($"Name: {d.Name}");
    Console.WriteLine($"Type: {d.DriveType}");

    if (d.IsReady)
    {
        Console.WriteLine($"Free space: {d.TotalFreeSpace}");
        Console.WriteLine($"Format: {d.DriveFormat}");
        Console.WriteLine($"Label: {d.VolumeLabel}");
    }
}
