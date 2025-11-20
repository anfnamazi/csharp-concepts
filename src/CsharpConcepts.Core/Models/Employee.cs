namespace CsharpConcepts.Core.Models;

public class Employee(string name, string role) : Person(name)
{
    public string Role { get; set; } = role;

    public override string GetId()
    {
        return $"{Role}-{base.GetId()}";
    }
}
