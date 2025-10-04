namespace CarRentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[]
            {
                new Car(1, "Toyota Corolla", CarType.Sedan, false, 400, new Dimensions(1.8, 1.5, 4.5)),
                new Car(2, "Honda CRV", CarType.SUV, true, 600, new Dimensions(2.0, 1.7, 4.8)),
                new Car(3, "Hyundai Elantra", CarType.Sedan, true, 500, new Dimensions(1.9, 1.5, 4.6)),
            };
            RentalService rental = new RentalService(cars);
            rental.ShowAvailableCars();
            Car mostExpen=rental.GetMostExpensiveCar();
            mostExpen.DisplayInfo();
            int[] rentalDays = { 0, 3, 2 };// عدد ايام الايجار لكل عربيه
            Console.WriteLine($"total revenue { rental.CalculateTotalRevenue(rentalDays)}");
            rental.ChangeRentalStatusById(1, true);
            Console.WriteLine($"After filter ");
            rental.FilterCarType(CarType.Sedan);
        }
    }
}
