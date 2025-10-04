namespace DivisionHelper
{
    internal class Program
    {
        static void DivideAndRemainder(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your dividend");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your divisor");
            int divisor = int.Parse(Console.ReadLine());
            DivideAndRemainder(dividend, divisor,out int quotient,out int remainder);
            Console.WriteLine($"quotient= {quotient} remainder= {remainder} ");

        }
    }
}
