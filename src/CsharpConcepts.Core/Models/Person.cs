namespace CsharpConcepts.Core.Models;

public class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }

    public void PrintGreeting()
    {
        Console.WriteLine($"Hello, {Name}");
    }

    public virtual string GetId()
    {
        return Name.ToLower();
    }
}
