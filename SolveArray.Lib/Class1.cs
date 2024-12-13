namespace SolveArray.Lib;

public class ArrayCustom
{
    public double CalculateMin(double[] array)
    {
        return array.Min();
    }
    public double CalculateMax(double[] array)
    {
        return array.Max();
    }
    public double CalculateMid(double[] array)
    {
        
        double resultAvg = array.Average();

        
        return Math.Round(resultAvg, 2);
    }
    public double CalculateMedian(double[] array)
    {
        var sortedArray = array.OrderBy(x => x).ToArray();

        double median;
        int n = array.Length;

        if (n % 2 == 1)
        {
            median = array[n / 2];
        }
        else
        {
            median = (array[(n / 2) - 1] + array[n / 2]) / 2.0;
        }

        return median;
    }
    public int CalculateNumberOfEven(double[] array)
    {
        int evenCount = 0;

        foreach (double number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        return evenCount;
    }
    public int CalculateNumberOfOdd(double[] array)
    {
        int oddCount = 0;

        foreach (int number in array)
        {
            if (number % 2 != 0)
            {
                oddCount++;
            }
        }

        return oddCount;

    }
    public int SignsOfDivisibilityByTwo(double[] array)
    {
        int divisibleByTwoCount = 0;


        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                divisibleByTwoCount++;
            }
        }

        return divisibleByTwoCount;
    }
    public int SignsOfDivisibilityByThree(double[] array)
    {
        int divisibleByThreeCount = 0;

        foreach (int number in array)
        {
            if (number % 3 == 0)
            {
                divisibleByThreeCount++;
            }
        }

        return divisibleByThreeCount;
    }
    public int SignsOfDivisibilityByFive(double[] array)
    {
        int divisibleByFiveCount = 0;

        foreach (int number in array)
        {
            if (number % 5 == 0)
            {
                divisibleByFiveCount++;
            }
        }

        return divisibleByFiveCount;
    }
    public int SignsOfDivisibilityByTen(double[] array)
    {
        int divisibleByTenCount = 0;

        foreach (int number in array)
        {
            if (number % 10 == 0)
            {
                divisibleByTenCount++;
            }
        }

        return divisibleByTenCount;
    }
}
