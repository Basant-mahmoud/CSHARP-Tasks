using System.Collections.Generic;
using System.Security.Claims;

namespace Day2_task3
{
    internal class Program
    {
        static int longDistance(int[] arr)
        {
            int[] result = new int[arr.Length]; ;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {

                        result[i] = (j - i) - 1;
                    }
                }

            }
            return result.Max();
        }
        static int countoneintNumber(long n)
        {
            int count = 0;
            while (n > 0)
            {
                if (n % 10 == 1)
                {
                    count++;
                }
                n /= 10;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter size  in array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"enter element in index {i + 1}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Longest distance: {longDistance(arr)}");
            //q2
            Console.WriteLine(" enter string you want to reverse");
            string input = Console.ReadLine();
            string output = string.Join(" ", input.Split(' ').Reverse());
            Console.WriteLine(output);
            long cont = 0;
            for (long i = 1; i < 99999999; i++)
            {
                //math
                cont += countoneintNumber(i);
                //cont+=i.Tostring().Count(c=>c=='1);
            }
            Console.WriteLine($"{cont}");
            //optmize way
            //for (long place = 1; place <= n; place *= 10)
            //{
            //    long divider = place * 10;
            //    count += (n / divider) * place + Math.Min(Math.Max(n % divider - place + 1, 0), place);
           // }



        }

    }
}
