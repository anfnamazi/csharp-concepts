using CsharpConcepts.Core.Interfaces;
using CsharpConcepts.Core.Models;

namespace CsharpConcepts.Demos.OOP;

public class OverloadMethodDemo : IDemo
{
    public static void Run()
    {
        Account account = new Account("test", 2);
        Console.WriteLine($"Owner: {account.Owner}, Balance: {account.Balance}");
    }
}
