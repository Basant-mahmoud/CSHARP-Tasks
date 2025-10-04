namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Student you have");
            int NumStudent = int.Parse(Console.ReadLine());

            int[][] Marks = new int[NumStudent][];
            

            for (int i=0;i< NumStudent; i++)
            {
                Console.WriteLine($" Number of subject ");
                int NumSub = int.Parse(Console.ReadLine());
                Console.WriteLine($" Student Number   {i+1}");
                Marks[i] = new int[NumSub];
                int total = 0;
                for(int j = 0; j < NumSub; j++)
                {
                    Marks[i][j] = int.Parse(Console.ReadLine());
                    total += Marks[i][j];

                }
                double avg = (double)total / NumSub;
                Console.WriteLine($"Total is   {total}");
                Console.WriteLine($"avarage is   {avg}");



            }
        }
    }
}
