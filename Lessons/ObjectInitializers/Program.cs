using ObjectInitializers;

Console.WriteLine("***** Fun with Object Init Syntax *****\n");
var myRect = new Rectangle
{
    TopLeft = new Point { X = 10, Y = 10 },
    BottomRight = new Point { X = 50, Y = 50 }
};