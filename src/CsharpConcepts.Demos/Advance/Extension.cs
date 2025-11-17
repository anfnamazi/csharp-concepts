using CsharpConcepts.Core.Interfaces;
using CsharpConcepts.Core.Models;

namespace CsharpConcepts.Demos.Advance;

static class RectangleExtension
{
    // can use class
    public static int CalcArea(this Rectangle rectangle)
    {
        var area = rectangle.Width * rectangle.Height;
        return area;
    }

    // can use interface
    public static int CalcPerimeter(this IRectangle rectangle)
    {
        var perimeter = (rectangle.Width + rectangle.Height) * 2;
        return perimeter;
    }
}

public class ExtensionDemo : IDemo
{
    public static void Run()
    {
        var rectangle = new Rectangle(3, 4);
        Console.WriteLine($"Rectangle Area: {rectangle.CalcArea()}");
        Console.WriteLine($"Rectangle Perimeter: {rectangle.CalcPerimeter()}");
    }
}
