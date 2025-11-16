Console.WriteLine("***** Simple I/O with the File Type *****\n");
string[] myTasks = {
    "Fix bathroom sind", "Call Dave",
    "Call Mom and Dad", "Play Xbox One"};

File.WriteAllLines("ToDoList.txt", myTasks);

foreach (string task in File.ReadAllLines("ToDoList.txt"))
{
    Console.WriteLine("TODO: {0}", task);
}

File.Delete("ToDoList.txt");