using ObjectOverrides;

Console.WriteLine("***** Fun with System.Object *****\n");
Person p1 = new Person("Homer", "Simpson", 50, "111-11-1111");
Person p2 = new Person("Homer", "Simpson", 50, "111-11-1111");

Console.WriteLine($"p1.ToString() = {p1.ToString()}");
Console.WriteLine($"p2.ToString() = {p2.ToString()}");
Console.WriteLine($"p1 = p1?: {p1.Equals(p2)}");
Console.WriteLine($"Same hash codes?: {p1.GetHashCode() == p2.GetHashCode()}");