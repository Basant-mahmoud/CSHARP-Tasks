using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    class Car
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public CarType Type { get; set; }
        public bool IsRented { get; set; }
        public double DailyRat { get; set; }
        public Dimensions Size { get; set; }
        public Car(int _id, string model, CarType type, bool isrented, double dailyrate, Dimensions size)
        {
            CarId = _id;
            Model = model;
            Type = type;
            IsRented = isrented;
            DailyRat = dailyrate;
            Size = size;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Car ID: {CarId}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Is Rented: {(IsRented ? "Yes" : "No")}");
            Console.WriteLine($"Daily Rate: {DailyRat} EGP");
            Console.WriteLine($"Size => Width: {Size.Width}, Height: {Size.Height}, Length: {Size.Length}");
            Console.WriteLine(new string('-', 40));
        }
    }
    }
