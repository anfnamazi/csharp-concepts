using CsharpConcepts.Core.Collections;
using CsharpConcepts.Core.Interfaces;

namespace CsharpConcepts.Demos.LINQ;

public class FilteringDemo : IDemo
{
    public static void Run()
    {
        // Data source
        CollectionList.numberList.Sort();

        // Query creation
        var evenNumbers = CollectionList.numberList.Where(n => n % 2 == 0);
        // run immediately
        // var evenNumbers = CollectionList.numberList.Where(n => n % 2 == 0).ToList();

        CollectionList.numberList.Add(7);
        CollectionList.numberList.Add(8);

        // Query execution
        foreach (var i in evenNumbers)
        {
            Console.Write("{0,1} ", i);
        }
    }
}
