using System.Collections.ObjectModel;

namespace FunWithObservableCollections;


public class Person
{
    public int Age { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person()
    {
    }

    public Person(string firstName, string lastName, int age)
    {
        Age = age;
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, Age: {Age}";
    }
}

ObservableCollection<Person> people = new ObservableCollection<Person>()
{
    new Person{ FirstName = "Peter", LastName = "Murphy", Age = 52},
    new Person{ FirstName = "Kevin", LastName = "Key", Age = 48}
};

people.CollectionChanged += people_CollectionChanged;
static void people_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
{
    Console.WriteLine($"Action for this event: {e.Action}");

    if (e.Action == NotifyCollectionChangedAction.Remove)
    {
        Console.WriteLine("Here are thi OLD items:");
        foreach (Person p in e.OldItems)
        {
            Console.WriteLine(p.ToString());
        }
        Console.WriteLine();
    }

    if (e.Action == NotifyCollectionChangedAction.Add)
    {
        Console.WriteLine("Here are the NEW items;");
        foreach (Person p in e.NewItems)
            Console.WriteLine(p.ToString());
    }
}

people.Add(new Person("Fred", "Smith", 32));
people.RemoveAt(0);