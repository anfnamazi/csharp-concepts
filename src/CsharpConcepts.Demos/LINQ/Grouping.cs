using CsharpConcepts.Core.Collections;
using CsharpConcepts.Core.Interfaces;

namespace CsharpConcepts.Demos.LINQ;

public class GroupingDemo : IDemo
{
    public static void Run()
    {
        var groupedEmployee = CollectionList.employeeList.GroupBy(e => e.Role);

        foreach (var role in groupedEmployee)
        {
            Console.WriteLine($"Role: {role.Key}");

            foreach (var e in role)
            {
                Console.WriteLine($"  Employee: {e.Name}");
            }
        }

        Console.WriteLine("----------------");
        var jessicaGroupedEmployee = CollectionList
            .employeeList.Where(e => e.Name.Contains("Jessica"))
            .GroupBy(e => e.Role);
        foreach (var role in jessicaGroupedEmployee)
        {
            Console.WriteLine($"Role: {role.Key}");

            foreach (var e in role)
            {
                Console.WriteLine($"  Employee: {e.Name}");
            }
        }
    }
}
