namespace CountVowelsinaSentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence or word:");
            string word = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char c = char.ToLower(word[i]);
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine($"Number of vowels: {count}");
        }
    }
}
