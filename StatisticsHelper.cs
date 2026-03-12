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

        double avg = (double)sum / values.Length;
        return Math.Round(avg, 2);
    }

    public static int CalculateMax(int[] values) {
        if (values == null || values.Length == 0) return 0;

        int max = values[0];
        foreach (var v in values) {
            if (v > max) max = v;
        }
        return max;
    
    }
}