using CsharpConcepts.Core.Collections;
using CsharpConcepts.Core.Interfaces;

namespace CsharpConcepts.Demos.LINQ;

public class SelectingDemo : IDemo
{
    public static void Run()
    {
        var lastNames = CollectionList.recordPersonList.Select(p => p.LastName);
        foreach (var i in lastNames)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("-------------------");
        var firstNameWithAge20To40 = CollectionList
            .recordPersonList.Where(p => p.Age >= 20 && p.Age <= 40)
            .Select(p => p.FirstName);
        foreach (var i in firstNameWithAge20To40)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("-------------------");
        var first = CollectionList.recordPersonList.First();
        Console.WriteLine(first.Bio);

        Console.WriteLine("-------------------");
        var conditionFirst = CollectionList.recordPersonList.FirstOrDefault(p => p.Age > 50);
        Console.WriteLine(conditionFirst?.Bio);

        Console.WriteLine("-------------------");
        var takeAndSkip = CollectionList.recordPersonList.Skip(1).Take(2);
        foreach (var i in takeAndSkip)
        {
            Console.WriteLine(i.Bio);
        }
    }
}
