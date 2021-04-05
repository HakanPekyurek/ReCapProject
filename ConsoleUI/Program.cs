using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandAddTest();
            //CarUpdateTest();
            //ColorDeleteTest();
        }

        private static void ColorDeleteTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color newColor = new Color
            {
                Id = 1002
            };

            colorManager.Delete(newColor);
        }

        private static void CarUpdateTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car updateCar = new Car
            {
                Id = 1002,
                BrandId = 1,
                ColorId = 3,
                DailyPrice = 100,
                ModelYear = 2021,
                Description = "Değişen Araç",
                Name = "Egea Cross"
            };

            carManager.Update(updateCar);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand newBrand = new Brand
            {
                Name = "Alfa Romeo"
            };

            brandManager.AddBrand(newBrand);
        }

        private static void CarTest()
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
