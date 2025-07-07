using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Nullable Data *****");
            //var dr = new DatabaseReader();
            ////int myData = dr.GetIntFromDatabase() ?? 100;
            //int? myData = dr.GetIntFromDatabase();
            //if (!myData.HasValue)
            //{
            //    myData = 100;
            //}
            //Console.WriteLine($"Value of myData: {myData}");
            int? nullableInt = null;
            nullableInt ??= 12;
            nullableInt ??= 14;
            Console.WriteLine(nullableInt);
        }
    }
}
