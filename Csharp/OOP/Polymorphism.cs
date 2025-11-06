using Csharp.Interfaces;
using Csharp.Models;

namespace Csharp.OOP;

class Customer : Person
{
    public Customer(string name)
        : base(name) { }

    public override string GetId()
    {
        return $"{Name} Customer";
    }
}

class PolymorphismDemo : IDemo
{
    public static void Run()
    {
        Person regularPerson = new Person("John");
        Person employeePerson = new Employee("Joseph", "cto");
        Person customerPerson = new Customer("Anna");

        Console.WriteLine(
            @$"regular person: {regularPerson.GetId},
employee person: {employeePerson.GetId()},
customer person: {customerPerson.GetId()}"
        );
    }
}
