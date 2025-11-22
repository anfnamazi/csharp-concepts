using CsharpConcepts.Core.Models;
using CsharpConcepts.Demos.Advance;


namespace CsharpConcepts.Test;

[TestClass]
public sealed class RectangleExtensionTest
{
    [TestMethod]
    public void Calc_Area_Return12for3and4()
    {
        // Arrange
        var rectangle = new Rectangle(3, 4);
        // Act
        var area = rectangle.CalcArea();
        //Assert
        Assert.AreEqual(12, area);
    }
    [TestMethod]
    public void Calc_Perimeter_Return6for2and1()
    {
        // Arrange
        var rectangle = new Rectangle(2, 1);
        // Act
        var perimeter = rectangle.CalcPerimeter();
        //Assert
        Assert.AreEqual(6, perimeter);
    }
}
