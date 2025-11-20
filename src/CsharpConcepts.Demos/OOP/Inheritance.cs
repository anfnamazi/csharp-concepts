using CsharpConcepts.Core.Interfaces;
using CsharpConcepts.Core.Models;

namespace CsharpConcepts.Demos.OOP;

interface ISalary
{
    public decimal GetSalary();
}

class FormalEmployee : Employee, ISalary
{
    public FormalEmployee(string name, string role)
        : base(name, role) { }

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
        FormalEmployee employee = new FormalEmployee("Jessica", "CEO");

        Console.WriteLine($"Person: {person.GetId()}");
        Console.WriteLine($"Employee: {employee.GetId()}, Salary: {employee.GetSalary()}");
    }
}
