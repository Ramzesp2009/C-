using FunWithGenericCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods1
{
    public static class SwapFunctions
    {
        //public static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}

        public static void Swap(ref Person a, ref Person b)
        {
            Person temp = a;
            a = b; b = temp;
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine($"You sent the Swap() method a {typeof(T)}");
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
