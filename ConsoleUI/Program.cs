using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            var cars = carManager.GetAll();
            foreach (var car in cars)
            {
                Console.WriteLine(car.Description);
            }

            Car newCar = new Car { Id = 6, BrandId = 2, ColorId = 2, DailyPrice = 150, 
                                   ModelYear = 2020, Description = "Yeni Araç" };

            carManager.Add(newCar);
        }
    }
}
