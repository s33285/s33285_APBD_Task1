class Programc
{
    static void Main() {

        Console.WriteLine("Enter numbers(use space to separate): ");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Error");
            return;
        }

        string[] parts = input.Split(' ');
        int[] num = Array.ConvertAll(parts, int.Parse);
        double avg = StatisticsHelper.CalculateAverage(num);
        Console.WriteLine("Average: " + avg);
    }

}