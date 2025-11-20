using CsharpConcepts.Core.Collections;
using CsharpConcepts.Core.Interfaces;

namespace CsharpConcepts.Demos.LINQ;

public class OrderingDemo : IDemo
{
    public static void Run()
    {
        Console.WriteLine("####### Order by asc persons:");
        foreach (
            var i in CollectionList
                .recordPersonList.OrderBy(p => p.FirstName)
                .ThenBy(p => p.LastName)
        )
        {
            Console.WriteLine(i.FullName);
        }

        Console.WriteLine("####### Order by desc animals:");
        foreach (var i in CollectionList.animalList.OrderByDescending(a => a))
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("######### Reverse animals:");
        CollectionList.animalList.Reverse();
        foreach (var i in CollectionList.animalList)
        {
            Console.WriteLine(i);
        }
    }
}
