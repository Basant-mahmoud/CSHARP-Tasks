namespace Point3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString());

            Console.WriteLine(P);

            string pointStr = (string)P;
            Console.WriteLine(pointStr);

            Point3D P1 = ReadPointFromUser("P1");
            Point3D P2 = ReadPointFromUser("P2");

            if (P1 == P2)
                Console.WriteLine("P1 and P2 are equal");
            else
                Console.WriteLine("P1 and P2 are different");
        }

        static Point3D ReadPointFromUser(string pointName)
        {
            double x = ReadDouble($"Enter X for {pointName}: ");
            double y = ReadDouble($"Enter Y for {pointName}: ");
            double z = ReadDouble($"Enter Z for {pointName}: ");
            return new Point3D(x, y, z);
        }

        static double ReadDouble(string message)
        {
            double result;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (double.TryParse(input, out result))
                    return result;

                
                try
                {
                    result = Convert.ToDouble(input);
                    return result;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");

                }

                try
                {
                    result = double.Parse(input);
                    return result;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
    
}
