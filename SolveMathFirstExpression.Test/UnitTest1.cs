using SolveMathFirstExpression.Lib;
using Xunit;

namespace SolveMathFirstExmpression.Test;

public class ValidMathFirstExpression
{
    [Fact]
    public void TestCalculateFirstExpression()
    {
        double x = 4;
        double y = 3;

        MathFirstExpression ds = new MathFirstExpression();

        double res = ds.CalculateFirstExpression(x, y);

        double true_value = 1.288;

        Assert.Equals(true_value, res);
    }
}