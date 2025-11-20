using CsharpConcepts.Core.Collections;
using CsharpConcepts.Core.Interfaces;

namespace CsharpConcepts.Demos.LINQ;

public class QueryingDemo : IDemo
{
    public static void Run()
    {
        var employeeByRole =
            from employee in CollectionList.employeeList
            group employee by employee.Role into groupedEmployee
            orderby groupedEmployee.Key
            select groupedEmployee;

        foreach (var role in employeeByRole)
        {
            Console.WriteLine($"Role: {role.Key}");

            foreach (var e in role)
            {
                Console.WriteLine($"  Employee: {e.Name}");
            }
        }
    }
}
