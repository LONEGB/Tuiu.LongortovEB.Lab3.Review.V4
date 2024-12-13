using SolveTabMathFunction.Lib;
using Xunit;

namespace SolveTabMathFunction.Test;

public class ValidTabMathFuction
{
    [Fact]
    public void TestCalculateTabMathFuction()
    {
        TabMathFuction ds = new TabMathFuction();

        int startStep = 1;
        int stopStep = 3;

        double[][] result = ds.CalculateTabMathFuction(startStep, stopStep);

        double[][] true_value = new double[][]
        {
            new double[] { 1, 1.02 },
            new double[] { 2, -0.10 },
            new double[] { 3, -0.18 }
        };

        Assert.Equals(true_value, result);

    }
}