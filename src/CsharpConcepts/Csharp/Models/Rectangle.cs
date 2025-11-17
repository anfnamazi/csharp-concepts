using Csharp.Interfaces;

namespace Csharp.Models;

class Rectangle : IRectangle
{
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Width
    {
        set; get;
    }

    public int Height
    {
        set; get;
    }
}