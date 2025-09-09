using System;
using ExtensionMethods;

Console.WriteLine("***** Fun with Extension Methods *****\n");
int myInt = 12345;
myInt.DisplayDefiningAssembly();
System.Data.DataSet d = new System.Data.DataSet();
d.DisplayDefiningAssembly();

//System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
//sp.DisplayDefiningAssembly();

Console.WriteLine($"Value of myInt: {myInt}");
Console.WriteLine($"Reversed digits of myInt: {myInt.ReverseDigits()}");

