using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    class RentalService
    {
        public Car[] Fleet { get; set; }
        public RentalService(Car[] Fleet)
        {
            this.Fleet = Fleet;
        }
        public void ShowAvailableCars()
        {
            Console.WriteLine("Available Cars:");
            foreach (var car in Fleet)
            {
                if (!car.IsRented)
                {
                    car.DisplayInfo();
                }
            }

        }
        public Car? GetMostExpensiveCar()
        {
            if (Fleet.Length == 0)
                return null;

            Car mostExpensive = Fleet[0];

            foreach (var car in Fleet)
            {
                if (car.DailyRat > mostExpensive.DailyRat)
                {
                    mostExpensive = car;
                }
            }

            return mostExpensive;
        }
        public double CalculateTotalRevenue(int[] rentalDays)
        {
            double totalrevenue = 0;
            for(int i=0;i<Fleet.Length;i++)
            {
                if (Fleet[i].IsRented == true)
                {
                    totalrevenue = Fleet[i].DailyRat * rentalDays[i];
                }
            }
            return totalrevenue;
        }
        public void ChangeRentalStatusById(int id,bool statues)
        {
            foreach(var car in Fleet)
            {
                if (car.CarId == id)
                {
                    car.IsRented = statues;
                }
            }
        }
        public void FilterCarType(CarType type)
        {
            foreach(var car in Fleet)
            {
                if (car.Type == type)
                {
                    car.DisplayInfo();
                }
            }
        }
        public Car[] DailyRate()
        {
           
            return Fleet.OrderByDescending(car => car.DailyRat).ToArray(); 


        }

    }
}
