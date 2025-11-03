using Csharp.Interfaces;
using Csharp.Models;

namespace Csharp.OOP;

interface ISalary
{
    public decimal GetSalary();
}

class Employee : Person, ISalary
{

    public Employee(string name, string role) : base(name)
    {
        Role = role;
    }

    public string Role { get; set; }

    public override string GetId()
    {
        return $"{Role}-{base.GetId()}";
    }

    public decimal GetSalary()
    {
        return 2000;
    }
}

public class InheritanceDemo : IDemo
{
    public static void Run()
    {
        Person person = new Person("John");
        Employee employee = new Employee("Jessica", "CEO");

        Console.WriteLine($"Person: {person.GetId()}");
        Console.WriteLine($"Employee: {employee.GetId()}, Salary: {employee.GetSalary()}");

    }
}