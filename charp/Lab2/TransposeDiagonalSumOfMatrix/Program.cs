namespace TransposeDiagonalSumOfMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your matrix size");
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix=new int[matrixSize,matrixSize];
            int digonal1=0, digonal2=0;
            int[,] TransposeMatrix = new int[matrixSize, matrixSize];
            for (int i=0;i<matrix.GetLength(0);i++)//iterate in row
            {
                for(int j = 0; j < matrix.GetLength(1); j++)// iterate in column
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    if (i == j)
                    {
                        digonal1 += matrix[i, j];
                    }
                    if (i + j == matrixSize)
                    {
                        digonal2 += matrix[i, j];
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)//iterate in row
            {
                for (int j = 0; j < matrix.GetLength(1); j++)// iterate in column
                {
                    TransposeMatrix[j, i] = matrix[i, j];
                }
            }
            Console.WriteLine("orginal Matrix");

            for (int i = 0; i < matrix.GetLength(0); i++)//iterate in row
            {
                for (int j = 0; j < matrix.GetLength(1); j++)// iterate in column
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Transpose Matrix");

            for (int i = 0; i < matrix.GetLength(0); i++)//iterate in row
            {
                for (int j = 0; j < matrix.GetLength(1); j++)// iterate in column
                {
                    Console.Write($"{TransposeMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($" digonal 1 is {digonal1} and digonal2 is {digonal2}");


        }

    }
}
