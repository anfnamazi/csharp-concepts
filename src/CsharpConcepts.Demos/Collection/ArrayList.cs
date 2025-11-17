using System.Collections;
using CsharpConcepts.Core.Interfaces;
using CsharpConcepts.Core.Models;

namespace CsharpConcepts.Demos.Collection;

public class ArrayListDemo : IDemo
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
