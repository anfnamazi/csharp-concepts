using CsharpConcepts.Core.Interfaces;

namespace CsharpConcepts.Demos.Collection;

public class GenericDictionaryDemo : IDemo
{
    public static void Run()
    {
        var grades = new Dictionary<int, string>() { { 3, "Good" } };
        grades.Add(2, "Almost");
        grades.TryAdd(1, "Bad");

        foreach (var g in grades)
        {
            Console.WriteLine($"{g.Key}: {g.Value}");
        }
        grades.Remove(1);
        foreach (var k in grades.Keys)
        {
            Console.WriteLine(k);
        }
        Console.WriteLine(grades.TryGetValue(3, out var Value));
        Console.WriteLine(grades.ContainsKey(1));
    }
}
