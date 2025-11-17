using CsharpConcepts.Core.Interfaces;

public class ValueTypesDemo : IDemo
{
    public static void Run()
    {
        Console.WriteLine("Enter name:");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello {name}");
        int age = 13;
        long myAge = age;
        float weight = 78.4f;
        int lessWeight = (int)weight;

        string result = age == 13 ? "13.0" : "12.0";
        Console.WriteLine(result);
    }
}
