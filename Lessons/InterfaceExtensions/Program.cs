using InterfaceExtensions;

Console.WriteLine("***** Extending Interface Compatible Types *****\n");
string[] data = { "Wow", "this", "is", "sort", "of", "annoying",
                    "but", "in", "a", "weird", "way", "fun!"};
data.PrintDataAndBeep();

List<int> myInts = new List<int>() { 10, 15, 20 };
myInts.PrintDataAndBeep();