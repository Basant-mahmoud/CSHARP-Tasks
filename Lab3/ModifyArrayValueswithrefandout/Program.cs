using System;

namespace ModifyArrayValueswithrefandout
{
    internal class Program
    {
        static void ModifyArray(ref int[] arr, out int sum)
        {
            sum = 0;   
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] += 5;
                sum += arr[i];
            }
        }
        static void SeperateEvenOdd(int[] arr,out int[]even,out int[] odd)
        {
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenList.Add(arr[i]);
                }
                else
                {
                    oddList.Add(arr[i]);
                }
            }
            even = evenList.ToArray();
            odd = oddList.ToArray();
        }
        static void Main(string[] args)
        {
            int[] arr = new int [] { 1, 2, 3, 4, 5 };
            ModifyArray(ref arr, out int sum);
            foreach(var num in arr)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine($"Total Sum is {sum}");


            SeperateEvenOdd(arr, out int[] even, out int[] odd);

            Console.WriteLine("Even numbers:");
            foreach (var num in even)
                Console.WriteLine(num);

            Console.WriteLine("Odd numbers:");
            foreach (var num in odd)
                Console.WriteLine(num);

        }
    }
}
