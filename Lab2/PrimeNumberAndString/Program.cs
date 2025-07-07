namespace PrimeNumberAndString
{
    internal class Program
    {
        static bool   isPrime(int num)
        {
            if (num <= 1)
                return false;
            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your element");
            int[] arr = new int[number];
            List<int> prime = new List<int>();
            int sumPrime = 0;

            for (int i = 0; i < number; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (isPrime(arr[i]))
                {
                    prime.Add(arr[i]);
                    sumPrime += arr[i];
                }
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            prime.Sort();
            Console.WriteLine("Prime number is ");
            foreach (var item in prime)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine($"sum of prime is {sumPrime}");
            Console.WriteLine("Sorted Array ");

            foreach (var item in arr)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
