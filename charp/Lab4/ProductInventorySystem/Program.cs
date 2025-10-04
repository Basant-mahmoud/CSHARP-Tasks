namespace ProductInventorySystem
{
    internal class Program
    {
       static double GetTotalPrice(Product[] products)
        {
            double sum = 0;
            for(int i = 0; i < products.Length; i++)
            {
                sum += (double)products[i].Price;
            }
            return sum;
        }
        static Product MostExpensive(Product[] products)
        {
            Product expen = products[0];
            double price = products[0].Price;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Price > price)
                {
                    expen = products[i];
                }
            }
            return expen;
        }
        static void Main(string[] args)
        {
            Product[] products = new Product[3];
            
            products[0] = new Product(
                         0,
                         "Lab",
                     Category.Electronics,
                         35000,
                     new Size(10, 5, 2)
                   );
            products[1] = new Product(
                        1,
                        "shirt",
                    Category.Clothing,
                        300,
                    new Size(10, 5, 2)
                  );
            products[2] = new Product(
                        2,
                        "tomato",
                    Category.Food,
                        45000,
                    new Size(10, 5, 2)
                  );
            foreach(var p in products)
            {
                p.display();
            }
            Console.WriteLine($"total price is {GetTotalPrice(products)}");
            Product most = MostExpensive(products);
        Console.WriteLine($"most expensive ");
            most.display();

        }
    }
}
