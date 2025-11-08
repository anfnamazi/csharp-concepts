// 1. Value Type vs Reference Type
// Feature	struct	class
// Type category	Value type	Reference type
// Stored in	Stack (usually)	Heap
// Assignment	Copies the entire value	Copies the reference (pointer)
// Example	Point p1 = p2; → new copy	Person p1 = p2; → both point to same object

// 2. Memory and Performance
// Structs are lightweight and best for small data structures.
// Classes are better for complex objects or when you need polymorphism.

// 3. Mutability and Behavior
// Structs are immutable by convention (though not enforced).
// Classes are typically mutable.
// Structs cannot have a parameterless constructor (until C# 10 with readonly struct).
// Structs cannot inherit from another struct or class (but can implement interfaces).
// Classes support inheritance and polymorphism.

using Csharp.Interfaces;

namespace Csharp.VarTypes;

struct Rectangle
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

class StructsDemo : IDemo
{
    public static void Run()
    {
        var rectangle = new Rectangle(30, 20);
        Console.Write($"rectangle width:{rectangle.Width}, height:{rectangle.Height}");
    }
}