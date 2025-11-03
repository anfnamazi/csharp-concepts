using Csharp.Interfaces;
using Csharp.Models;

namespace Csharp.Fundamental;

public class SetGetDemo : IDemo
{
    public static void Run()
    {
        Person person = new Person("John");
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Name);
        person.PrintGreeting();
    }
}
