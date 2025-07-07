using SpokeLessons;

var ms = new MyStack<int>();
ms.Push(1);
ms.Push(2);
ms.Push(3);
ms.Push(4);
ms.Push(5);
ms.Push('a');

foreach (var item in ms)
{
       Console.WriteLine(item);
}