using System;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            string s = "Hello World";
            list.Add(s);
            list.Add("hi");
            list.Add(50);
            list.Add(new object());

            var anArray = new[] { "more", "or", "less" };
            list.AddRange(anArray);

            var anotherArray = new[] { new object(), new ArrayList() };
            list.AddRange(anotherArray);

            list.Insert(3, "Hey there!");

            var moreString = new[] { "goodnight", "see ya" };
            list.InsertRange(4, moreString);

            list[3] = "Hey there, updated!";
            list.Add()
        }
    }

}