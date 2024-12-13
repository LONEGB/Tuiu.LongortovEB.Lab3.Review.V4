namespace SolveTabMathFunction.Lib;

public class TabMathFuction
{
    public double[][] CalculateTabMathFuction(int startStep, int stopStep)
    {
        int size = stopStep - startStep + 1;
        double[][] result = new double[size][];

        for (int x = startStep; x <= stopStep; x++)
        {
            int index = x - startStep;

            result[index] = new double[2];
            result[index][0] = x;
            result[index][1] = (x * x - 1 >= 0)
                ? Math.Sin(Math.Sqrt(x * x)) + (Math.Cos(x * x) / (3 * Math.Pow(x, 3))) - Math.Sin(Math.Sqrt(x * x - 1))
                : 0.0;
        }

        return result;
    }
}
