using CsharpConcepts.Core.Interfaces;

namespace CsharpConcepts.Demos.VarTypes;

public class ExceptionDemo : IDemo
{
    public static void Run()
    {
        string content = "";
        try
        {
            content = File.ReadAllText("test.txt");
            Console.WriteLine($"This file has been read: {content}");
        }
        catch (FileNotFoundException exception)
        {
            Console.WriteLine($"Cannot fine file: {exception.FileName}");
        }
        finally
        {
            Console.WriteLine($"Finally! length of content: {content.Length}");
        }
    }
}
