public static class StatisticsHelper
{

    public static double CalculateAverage(int[] values)
    {

        if (values == null || values.Length == 0)
        {
            Console.WriteLine("!Empty array!");
            return 0;
        }

        int sum = 0;

        foreach (var value in values) {
            sum += value;
        }

        return (double)sum / values.Length;
    }
}