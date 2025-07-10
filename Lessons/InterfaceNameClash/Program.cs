using InterfaceNameClash;

Console.WriteLine("***** Fun with Interface Name Clashes *****\n");
Octagon oct = new Octagon();
IDrawToForm itfForm = (IDrawToForm)oct;
itfForm.Draw();

Console.WriteLine(new string('*', 20));
((IDrawToPrinter)oct).Draw();

Console.WriteLine(new string('*', 20));
if (oct is IDrawToMemory dtm)
    dtm.Draw();
