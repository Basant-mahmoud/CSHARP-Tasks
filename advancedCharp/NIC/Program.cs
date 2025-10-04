namespace NIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NIC nic1 = NIC.GetInstance("Intel", "00-14-22-01-23-45", NICType.Ethernet);

            NIC nic2 = NIC.GetInstance("Another", "11-22-33-44-55-66", NICType.TokenRing);

            Console.WriteLine(nic1);
            Console.WriteLine();
            Console.WriteLine(nic2);

            Console.WriteLine($"\nAre both NIC objects the same? {ReferenceEquals(nic1, nic2)}");
        }
    }
}
