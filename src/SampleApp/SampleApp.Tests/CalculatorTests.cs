using NUnit.Framework;
using SampleApp;
using System.Runtime.InteropServices;

namespace SampleApp.Tests;

public class CalculatorTests
{
    [Test]
    public void Add_Works()
    {
        var calc = new Calculator();
        var result = calc.Add(3, 4);
        Assert.AreEqual(7, result);
    }

    [Test]
    public void Subtract_Works()
    {
        var calc = new Calculator();
        var result = calc.Subtract(5, 4);
        Assert.AreEqual(1, result);
    }

    [Test]
    public void Multiply_Works()
    {
        var calc = new Calculator();
        var result = calc.Multiply(3, 4);
        Assert.AreEqual(12, result);
    }

    [Test]
    public void Divide_Works()
    {
        var calc = new Calculator();
        var result = calc.Divide(10, 5);
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Divide_ByZero_Throws()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Divide(1, 0));
    }

    [TestCase(-2, "negative")]
    [TestCase(0, "zero")]
    [TestCase(3, "positive-odd")]
    [TestCase(4, "positive-even")]
    public void CategoryOf_CoversBranches(int input, string expected)
    {
        var calc = new Calculator();
        Assert.AreEqual(expected, calc.CategoryOf(input));
    }
}
