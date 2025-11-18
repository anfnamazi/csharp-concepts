using CsharpConcepts.Core.Interfaces;

namespace CsharpConcepts.Demos.Advance;

public class AsyncAwaitDemo
{
    public static async Task Run()
    {
        Console.WriteLine("async");
        var number = await Calc();
        Console.WriteLine(number);
    }

    static async Task<int> Calc()
    {
        await Task.Delay(4000);
        return 34;
    }
};
