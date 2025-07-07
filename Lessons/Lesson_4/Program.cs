namespace Lesson_4
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point3D = new Point3D(x:3, y:6, z:9);
            if (point3D is object)
            {
                Console.WriteLine("point3D is Point2D");
            }
            else
            {
                Console.WriteLine("point3D is not Point2D");
            }
        }
    }
}
