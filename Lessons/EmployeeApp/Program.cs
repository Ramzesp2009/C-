using EmployeeApp;

Console.WriteLine("***** Fun with encapsulation *****\n");
Employee emp = new Employee("Marvin", 45, 123, 1000, "111-111-1111", EmployeePayTypeEnum.Salaried);
Console.WriteLine(emp.Pay);
emp.GiveBonus(100);
Console.WriteLine(emp.Pay);
