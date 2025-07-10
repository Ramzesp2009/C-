using InterfaceHierarchy;

Console.WriteLine("***** Simple Interface Hierarchy *****\n");
BitmapImage myBitmap = new BitmapImage();
myBitmap.Draw();
myBitmap.DrawInBoundingBox(10, 10, 100, 150);
myBitmap.DrawUpsideDown();

if (myBitmap is IAdvancedDraw iAdvDraw)
    iAdvDraw.DrawUpsideDown();
