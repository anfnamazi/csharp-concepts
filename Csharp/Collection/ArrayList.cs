using System.Collections;
using Csharp.Interfaces;
using Csharp.Models;

namespace Csharp.Collection;

class ArrayListDemo : IDemo
{
    public static void Run()
    {
        var arrayList = new ArrayList();
        var day = 22;
        arrayList.Add(day);
        var person = new Person("John");
        arrayList.Add(person);
        Console.WriteLine(arrayList[0]);
        Console.WriteLine(arrayList[1]);
    }
}
