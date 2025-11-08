using Csharp.Interfaces;
using Csharp.Models;

namespace Csharp.VarTypes;


class MethodParameters
{
    public static void ChangeHeight(IRectangle rectangle)
    {
        rectangle.Height = 500;
    }
    public static void ChangeHeightRef(ref StructRectangle rectangle)
    {
        rectangle.Height = 500;
    }
}

class ValueReference : IDemo
{
    public static void Run()
    {
        var structRectangle = new StructRectangle(200, 300);
        var rectangle = new Rectangle(400, 600);

        MethodParameters.ChangeHeight(structRectangle);
        MethodParameters.ChangeHeight(rectangle);

        Console.Write($"struct rectangle height:{structRectangle.Height}");
        Console.Write($"rectangle height:{rectangle.Height}");

        MethodParameters.ChangeHeightRef(ref structRectangle);
        Console.Write($"ref struct rectangle height:{rectangle.Height}");
    }
}

