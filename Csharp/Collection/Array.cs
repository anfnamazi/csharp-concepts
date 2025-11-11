using Csharp.Interfaces;
using Csharp.Models;

namespace Csharp.Collection;

class ArrayDemo : IDemo
{
    public static void Run()
    {
        var array1 = new int[2];
        array1[0] = 4;
        array1[1] = 6;
        Console.WriteLine(array1);
        Console.WriteLine(array1[0]);

        var array2 = new int[] { 4, 6 };
        Console.WriteLine(array2);
        Console.WriteLine(array2[0]);

        int[] array3 = { 4, 6 };
        Console.WriteLine(array3);
        Console.WriteLine(array3[0]);

        var persons = new Person[2];
        persons[0] = new Person("John");
        persons[1] = new Person("Jessica");
        Console.WriteLine(persons);
        Console.WriteLine(persons[0].Name);

        foreach (var person in persons)
        {
            Console.WriteLine(person.Name);
        }
    }
}
