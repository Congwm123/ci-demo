using CiDemo.Core;

namespace CiDemo.Tests;

public class CalculatorTests
{
    private readonly Calculator _calc = new();

    [Fact]
    public void Add_TwoNumbers_ReturnsSum() => Assert.Equal(5, _calc.Add(2, 3));

    [Fact]
    public void Divide_ByZero_Throws() =>
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(10, 0));
}