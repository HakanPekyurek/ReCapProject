using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car newCar = new Car
            {
                BrandId = 1,
                ColorId = 3,
                DailyPrice = 100,
                ModelYear = 2021,
                Description = "Yeni Araç",
                Name = "Egea"
            };

            carManager.Add(newCar);
        }
    }
}
