using CsharpConcepts.Core.Interfaces;
using CsharpConcepts.Core.Models;

namespace CsharpConcepts.Demos.VarTypes;

class MethodParameters
{
    public static void ChangeHeight(IRectangle rectangle)
    {
        rectangle.Height = 500;
        rectangle = new Rectangle(200, 540);
    }

    public static void ChangeHeightRefStruct(ref StructRectangle rectangle)
    {
        rectangle.Height = 500;
    }

    public static void ChangeHeightRef(ref Rectangle rectangle)
    {
        rectangle.Height = 500;
        rectangle = new Rectangle(200, 440);
    }
}

public class ValueReference : IDemo
{
    public static void Run()
    {
        var structRectangle = new StructRectangle(200, 300);
        var rectangle = new Rectangle(400, 600);

        MethodParameters.ChangeHeight(structRectangle);
        MethodParameters.ChangeHeight(rectangle);

        Console.WriteLine($"struct rectangle height:{structRectangle.Height}");
        Console.WriteLine($"rectangle height:{rectangle.Height}");

        MethodParameters.ChangeHeightRefStruct(ref structRectangle);
        Console.WriteLine($"ref struct rectangle height:{structRectangle.Height}");

        MethodParameters.ChangeHeightRef(ref rectangle);
        Console.WriteLine($"ref struct rectangle height:{rectangle.Height}");
    }
}
