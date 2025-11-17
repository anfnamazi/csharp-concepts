using CsharpConcepts.Core.Interfaces;

namespace CsharpConcepts.Core.Models;

public class Rectangle : IRectangle
{
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Width { set; get; }

    public int Height { set; get; }
}
