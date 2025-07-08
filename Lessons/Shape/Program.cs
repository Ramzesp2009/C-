using Figure;

Console.WriteLine("***** Fun with Polimorphizm *****\n");

ThreeDCircle o = new ThreeDCircle();
o.Draw();
((Circle)o).Draw();