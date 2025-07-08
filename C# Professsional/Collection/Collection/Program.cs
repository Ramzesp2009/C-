using System.Collections;
using Collection.Collection;

var collection = new UserCollection();
collection[0] = new Element(1, 2);
collection[1] = new Element(3, 4);
collection[2] = new Element(5, 6);
collection[3] = new Element(7, 8);

foreach (Element element in collection)
{
    Console.WriteLine($"FieldA: {element.FieldA}, FieldB: {element.FieldB}");
}
Console.WriteLine(new string('-', 20));
foreach (Element element in collection)
{
    Console.WriteLine($"FieldA: {element.FieldA}, FieldB: {element.FieldB}");
}
Console.WriteLine(new string('-', 20));
IEnumerator enumerator = (collection as IEnumerable).GetEnumerator();
while (enumerator.MoveNext())
{
    Element element = enumerator.Current as Element;
    Console.WriteLine($"FieldA: {element.FieldA}, FieldB: {element.FieldB}");
}