using System;
using System.Collections.Generic;
using Collection.Collection_2;
namespace Collection.Collection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using UserCollection with Element type
            var collection = new UserCollection<Element>();
            collection[0] = new Element(1, 2);
            collection[1] = new Element(3, 4);
            collection[2] = new Element(5, 6);
            collection[3] = new Element(7, 8);
            foreach (var element in collection)
            {
                Console.WriteLine($"{element.FieldA}, {element.FieldB}");
            }
            Console.WriteLine(new string('-', 5));
            foreach (var element in collection)
            {
                Console.WriteLine($"{element.FieldA}, {element.FieldB}");
            }
        }
    }
}