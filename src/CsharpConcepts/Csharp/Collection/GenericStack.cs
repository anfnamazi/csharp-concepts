using Csharp.Interfaces;
using Csharp.Models;

namespace Csharp.Collection;

public class GenericStackDemo : IDemo
{
    public static void Run()
    {
        var stack = new Stack<Person>();
        var person1 = new Person("John");
        var person2 = new Person("Jessica");
        var person3 = new Person("Robert");
        stack.Push(person1);
        stack.Push(person2);
        stack.Push(person3);
        foreach (var p in stack)
        {
            Console.WriteLine(p.Name);
        }
        var pop = stack.Pop();
        Console.WriteLine(pop.Name);
        var peek = stack.Peek();
        Console.WriteLine(peek.Name);
    }
}
