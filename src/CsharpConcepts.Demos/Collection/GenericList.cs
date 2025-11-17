using CsharpConcepts.Core.Interfaces;
using CsharpConcepts.Core.Models;

namespace CsharpConcepts.Demos.Collection;

public class GenericListDemo : IDemo
{
    public static void Run()
    {
        var personList = new List<Person>();
        var person1 = new Person("John");
        var person2 = new Person("Jessica");
        personList.Add(person1);
        personList.Add(person2);

        foreach (var person in personList)
        {
            Console.WriteLine(person.Name);
        }
    }
}
