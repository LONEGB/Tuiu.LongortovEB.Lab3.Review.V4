using SolveCalculate.Lib;
using Xunit;

namespace SolveCalculate.Test;

public class ValidCalculate
{
    [Fact]
    public void TestCalculateAdd()
    {
        Calculate calc = new Calculate();
        int num1 = 5;
        int num2 = 2;

        int result = calc.CalculateAdd(num1, num2);

        int true_value = 7;

        Assert.Equals(true_value, result);
    }
    [Fact]
    public void TestCalculateSubt()
    {
        Calculate calc = new Calculate();

        int num1 = 7;
        int num2 = 2;

        int result = calc.CalculateSubt(num1, num2);

        int true_value = 5;

        Assert.Equals(true_value, result);
    }
    [Fact]
    public void TestCalculateMult()
    {
        Calculate calc = new Calculate();

        int num1 = 5;
        int num2 = 3;

        int result = calc.CalculateMult(num1, num2);

        int true_value = 15;

        Assert.Equals(true_value, result);
    }
    [Fact]
    public void TestCalculateDiv()
    {
        Calculate calc = new Calculate();

        double num1 = 15;
        double num2 = 3;

        double result = calc.CalculateDiv(num1, num2);

        double true_value = 5;

        Assert.Equals(true_value, result);
    }
}