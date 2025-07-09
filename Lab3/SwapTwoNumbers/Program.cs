namespace SwapTwoNumbers
{
    internal class Program
    {
        static void SwapValues(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void ReverseArray(ref int[] arr)
        {
            Array.Reverse(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter frist number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Second number");
            int num2 = int.Parse(Console.ReadLine());
            SwapValues(ref num1, ref num2);
            Console.WriteLine($"Number After Swapping{num1}  {num2}");
            Console.WriteLine("Enter Your Array Size");
            int siz = int.Parse(Console.ReadLine());
            int[] arr = new int[siz];
            for(int i = 0; i < siz; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            ReverseArray(ref arr);
            Console.WriteLine("Elemet After reverse Array");
            foreach(var num in arr)
            {
                Console.Write(num);
            }

        }
    }
}
