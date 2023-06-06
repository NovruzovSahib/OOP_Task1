using OOP_Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee();

        employee.Id = 1;
        employee.Name = "Max";
        employee.Surname = "Lindegaard";
        employee.Age = 30;
        employee.Position = "IT Support";
        employee.Workplace = "Technology ";
        employee.Salary = 1500;

        Console.WriteLine($"{employee.Id}\n{employee.Name}\n{employee.Surname}\n{employee.Age}\n{employee.Workplace}\n{employee.Position}\n{employee.Salary}\n{employee.Country}\n");
        employee.GetInfo1();
        employee.GetInfo2();

        Console.ReadLine();
    }
}