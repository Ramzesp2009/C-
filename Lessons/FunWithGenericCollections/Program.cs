using System;
using System.Collections.Generic;
using FunWithGenericCollections;

Console.WriteLine("***** Fun with Generic Collections *****");
// UseGenericList();

// UseGenericStack();

// UseGenericQueue();

// UseSortedSet();

UseDictionary();


static void UseGenericList()
{
    List<Person> people = new List<Person>()
    {
        new Person {FirstName = "Homer", LastName = "Simpson", Age = 47},
        new Person {FirstName = "Marge", LastName = "Simpson", Age = 40},
        new Person {FirstName = "Bart", LastName = "Simpson", Age = 10},
        new Person {FirstName = "Lisa", LastName = "Simpson", Age = 8},
    };
    Console.WriteLine("Items in list: {0}", people.Count);
    foreach (var p in people)
    {
        Console.WriteLine(p);
    }

    Console.WriteLine("\n->Inserting new person");
    people.Insert(2, new Person {FirstName = "Maggie", LastName = "Simpson", Age = 1});
    // people.Add(new Person {FirstName = "Lora", LastName = "Simpson", Age = 11});
    Console.WriteLine("Items in list: {0}", people.Count);
    Person[] arrayOfPeople = people.ToArray();
    foreach (var p in arrayOfPeople)
    {
        Console.WriteLine("First Names: {0}", p.FirstName);
    }
}

static void UseGenericStack()
{
    Stack<Person> stackOfPeople = new();
    stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47});
    stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45});
    stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9});
    Console.WriteLine($"First person is: {stackOfPeople.Peek()}");
    Console.WriteLine($"Popped off {stackOfPeople.Pop()}");
    Console.WriteLine($"\nFirst person is: {stackOfPeople.Peek()}");
    Console.WriteLine($"Popped off {stackOfPeople.Pop()}");
    Console.WriteLine($"\nFirst person is: {stackOfPeople.Peek()}");
    Console.WriteLine($"Popped off {stackOfPeople.Pop()}");
    try
    {
        Console.WriteLine($"\nFirst person is: {stackOfPeople.Peek()}");
        Console.WriteLine($"Popped off {stackOfPeople.Pop()}");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("\nError! Stack is empty!");
        Console.WriteLine(ex.Message);
    }
}

static void UseGenericQueue()
{
    Queue<Person> peopleQ = new();
    peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47});
    peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45});
    peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9});
    Console.WriteLine($"{peopleQ.Peek().FirstName} is first in line!");
    GetCoffee(peopleQ.Dequeue());
    GetCoffee(peopleQ.Dequeue());
    GetCoffee(peopleQ.Dequeue());
    try
    {
        GetCoffee(peopleQ.Dequeue());
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("\nError! Queue is empty");
        Console.WriteLine(ex.Message);
    }

    static void GetCoffee(Person p)
    {
        Console.WriteLine($"{p.FirstName} got coffee!");
    }
}

static void UseSortedSet()
{
    SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
    {
        new Person {FirstName = "Homer", LastName = "Simpson", Age = 47},
        new Person {FirstName = "Marge", LastName = "Simpson", Age = 45},
        new Person {FirstName = "Lisa", LastName = "Simpson", Age = 9},
        new Person {FirstName = "Bart", LastName = "Simpson", Age = 10},
    };

    foreach (var p in setOfPeople)
    {
        Console.WriteLine(p);
    }

    Console.WriteLine();
    setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
    setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });
    foreach (var p in setOfPeople)
    {
        Console.WriteLine(p);
    }
}

static void UseDictionary()
{
    Dictionary<string, Person> peopleA = new();
    peopleA["Homer"] = new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 };
    peopleA["Marge"] = new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 };
    peopleA["Lisa"] = new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 };
    peopleA["Bart"] = new Person { FirstName = "Bart", LastName = "Simpson", Age = 10 };
    Person homer = peopleA["Homer"];
    Console.WriteLine(homer);
    
    Dictionary<string, Person> peopleB = new()
    {
        { "Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 } },
        { "Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 } },
        { "Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 } },
        { "Bart", new Person { FirstName = "Bart", LastName = "Simpson", Age = 10 } },
    };
    Person lisa = peopleB["Lisa"];
    Console.WriteLine(lisa);
}