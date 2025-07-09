namespace ArrayStatistics
{
    internal class Program
    {
        static void CalculateArrayStats(int[] scores, out int max, out int min, out double average)
        {
            max = int.MinValue;
            min = int.MaxValue;
            int sum = 0;
            for(int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
                if (scores[i] > max)
                {
                    max = scores[i];
                }
                if (scores[i] < min)
                {
                    min = scores[i];
                }

            }
            average = sum / scores.Length;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Student You Have");
            int Student = int.Parse(Console.ReadLine());

            int[] Score = new int[Student];
            for(int i = 0; i < Student; i++)
            {
                Console.WriteLine($"Enter student score {i+1}");

                Score[i] = int.Parse(Console.ReadLine());
            }
            CalculateArrayStats(Score, out int max, out int min, out double average);
            Console.WriteLine($"max score is {max} and min score is {min} and avarage score is {average}");
        }
    }
}
