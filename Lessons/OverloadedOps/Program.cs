using System;
using OverloadedOps;


Console.WriteLine("***** Fun with Overloaded Operators *****\n");
Point ptOne = new Point(100, 100);
Point ptTwo = new Point(40, 40);
Console.WriteLine($"ptOne = {ptOne}");
Console.WriteLine($"ptTwo = {ptTwo}");
Console.WriteLine($"ptOne + ptTwo: {ptOne + ptTwo}");
Console.WriteLine($"ptOne - ptTwo: {ptOne - ptTwo}");
Console.WriteLine();
Point beggerPoint = ptOne + 10;
Console.WriteLine($"ptOne + 10 = {beggerPoint}");
Console.WriteLine($"ptOne == ptTwo : {ptOne == ptTwo}");
Console.WriteLine($"ptOne != ptTwo : {ptOne != ptTwo}");
Console.WriteLine($"ptOne < ptTwo : {ptOne < ptTwo}");
Console.WriteLine($"ptOne > ptTwo : {ptOne > ptTwo}");