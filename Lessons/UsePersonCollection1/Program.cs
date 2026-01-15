using IssuesWithNongenricCollections;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

//UseGenericList();
//UsePersonCollection();
static void UsePersonCollection()
{
    Console.WriteLine("***** Custom Person Collection *****\n");
    PersonCollection myPeople = new PersonCollection();
    myPeople.AddPerson(new Person("Homer", "Simpson", 40));
    myPeople.AddPerson(new Person("Marge", "Simpson", 38));
    myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
    myPeople.AddPerson(new Person("Bart", "Simpson", 7));
    myPeople.AddPerson(new Person("Maggie", "Simpson", 2));
    foreach (Person p in myPeople)
    {
        Console.WriteLine(p);
    }
    Console.ReadLine();
}

static void UseGenericList()
{
    Console.WriteLine("***** Fun with Generics *****\n");
    List<Person> morePeople = new List<Person>();
    morePeople.Add(new Person("Frank", "Black", 50));
    Console.WriteLine(morePeople[0]);
    List<int> moreInts = new List<int>();
    moreInts.Add(10);
    moreInts.Add(2);
    int sum = moreInts[0] + moreInts[1];
    Console.WriteLine(sum);
    Console.ReadLine();
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