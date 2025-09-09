using System.Reflection;

namespace TEST
{
    class Program
    {
        static void Main()
        {
            int myInt = 123456789;
            myInt.DisplayDefiningAssembly();
            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAssembly();
        }
    }

    static class ObjectExtensions
    {
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine($"{obj.GetType().Name} lives here:\n't->{Assembly.GetAssembly(obj.GetType())}");
        }
    }
}
