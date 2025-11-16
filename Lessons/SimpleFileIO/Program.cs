using System;
using System.IO;
using System.Timers;

Console.WriteLine("***** Simple IO with the File Type *****\n");
var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}tmp{Path.DirectorySeparatorChar}Test.dat";

FileInfo f = new FileInfo(fileName);
using (FileStream fs = f.Open(
    FileMode.OpenOrCreate,
    FileAccess.ReadWrite, 
    FileShare.None))
{
    Console.WriteLine("Created {0}", f.FullName);

    fs.Close();
}
Thread.Sleep(2000);
f.Delete();
Console.WriteLine("Deleted {0}", f.FullName);


FileInfo f2 = new FileInfo(fileName);
f2.Create().Close();

using (FileStream readOnlyStream = f2.OpenRead())
{
    Console.WriteLine("Opened {0} with read-only access", f2.FullName);
    readOnlyStream.Close();
}

f2.Delete();

FileInfo f3 = new FileInfo(fileName);
using(FileStream writeOnlyStream = f3.OpenWrite())
{
    writeOnlyStream.WriteByte(0xFF);
    Console.WriteLine("Opened {0} with write-only access", f3.FullName);
    writeOnlyStream.Close();
}
f3.Delete();

FileInfo f4 = new FileInfo(fileName);
f4.Create().Close();
using(StreamReader sreader = f4.OpenText())
{
    Console.WriteLine("Opened {0} with read access", f4.FullName);
    sreader.Close();
}

f4.Delete();

FileInfo f5 = new FileInfo(fileName);
using(StreamWriter swriter = f5.CreateText())
{
    swriter.WriteLine("Hello, World!");
    Console.WriteLine("Opened {0} with write access", f5.FullName);
    swriter.Close();
}
using(StreamReader sreader = f5.OpenText())
{
    Console.WriteLine("Reading from {0}:", f5.FullName);
    Console.WriteLine(sreader.ReadToEnd());
    sreader.Close();
}
using(StreamWriter swriter = f5.AppendText())
{
    swriter.WriteLine("Hello, Universe!");
    Console.WriteLine("Appended text to {0}", f5.FullName);
    swriter.Close();
}
using (StreamReader sreader = f5.OpenText())
{
    Console.WriteLine("Reading from {0}:", f5.FullName);
    Console.WriteLine(sreader.ReadToEnd());
    sreader.Close();
}
f5.Delete();