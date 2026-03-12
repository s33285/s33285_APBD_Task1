public static class StatisticsHelper
{

    public static double CalculateAverage(int[] values)
    {
        int sum = 0;

        foreach (var value in values) {
            sum += value;
        }

        return (double)sum / values.Length;
    }
}