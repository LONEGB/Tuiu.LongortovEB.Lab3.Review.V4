using SolveArray.Lib;
using Xunit;

namespace SolveArray.Test;

public class ValidArray
{
    [Fact]
    public void TestCalculateMin()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 4.0, 15.8, 32.0, 13.2, 88.0 };

        double result = ds.CalculateMin(testArray);

        double true_value = 4.0;

        Assert.Equals(true_value, result);
    }
    [Fact]
    public void TestCalculateMax()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 4.0, 15.8, 32.0, 13.2, 88.0 };

        double result = ds.CalculateMax(testArray);

        double true_value = 88.0;

        Assert.Equals(true_value, result);
    }
    [Fact]
    public void TestCalculateMid()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 4.0, 15.8, 32.0, 13.2, 88.0 };

        double result = ds.CalculateMid(testArray);

        double true_value = 30.6;

        Assert.Equals(true_value, result);
    }
    [Fact]
    public void TestCalculateMedian()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 4.0, 15.8, 32.0, 13.2, 88.0 };

        double result = ds.CalculateMedian(testArray);

        double true_value = 32.0;

        Assert.Equals(true_value, result);
    }
    [Fact]
    public void TestCalculateNumberOfEven()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 5.0, 8.0, 9.0, 2.0, 3.0 };

        int result = ds.CalculateNumberOfEven(testArray);

        int true_value = 2;

        Assert.Equals(true_value, result);
    }
    [Fact]
    public void TestCalculateNumberOfOdd()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 5.0, 8.0, 9.0, 2.0, 3.0 };

        int result = ds.CalculateNumberOfOdd(testArray);

        int true_value = 3;

        Assert.Equals(true_value, result);
    }
    [Fact]
    public void TestSignsOfDivisibilityByTwo()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 15.0, 2.0, 10.0, 11.0, 4.0 };

        int result = ds.SignsOfDivisibilityByTwo(testArray);

        int true_value = 4;

        Assert.Equals(true_value, result);
    }
    [Fact]
    public void TestSignsOfDivisibilityByThree()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 15.0, 2.0, 10.0, 11.0, 4.0 };

        int result = ds.SignsOfDivisibilityByThree(testArray);

        int true_value = 1;

        Assert.Equals(true_value, result);
    }
    [Fact]
    public void TestSignsOfDivisibilityByFive()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 15.0, 2.0, 10.0, 11.0, 4.0 };

        int result = ds.SignsOfDivisibilityByFive(testArray);

        int true_value = 2;

        Assert.Equals(true_value, result);
    }
    [Fact]
    public void TestSignsOfDivisibilityByTen()
    {
        ArrayCustom ds = new ArrayCustom();

        double[] testArray = { 15.0, 2.0, 10.0, 11.0, 4.0 };

        int result = ds.SignsOfDivisibilityByTen(testArray);

        int true_value = 1;

        Assert.Equals(true_value, result);
    }
}