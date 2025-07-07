using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public int age;
        public string group;

        public void Print()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Group: {group}");
        }

        public string GetFullName()
        {
            return $"{firstName} {lastName}";
        }
    }
}
