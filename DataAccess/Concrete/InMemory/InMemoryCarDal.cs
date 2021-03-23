﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id =1, BrandId=1, ColorId = 1, DailyPrice=100, ModelYear=2019, Description="Aile Aracı"},
                new Car {Id =2, BrandId=1, ColorId = 3, DailyPrice=100, ModelYear=2019, Description="Normal bagaj"},
                new Car {Id =3, BrandId=3, ColorId = 1, DailyPrice=100, ModelYear=2019, Description="Geniş Bagaj"},
                new Car {Id =4, BrandId=3, ColorId = 2, DailyPrice=100, ModelYear=2019, Description="7 Kişilik"},
                new Car {Id =5, BrandId=2, ColorId = 2, DailyPrice=100, ModelYear=2019, Description="Panelvan"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Yeni araç eklendi => Id: " + car.Id + " Description: " + car.Description);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(h => h.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(h => h.Id == id);
        }

        public void Update(Car car)
        {
            Car updateToCar = _cars.SingleOrDefault(h => h.Id == car.Id);
            updateToCar.BrandId = car.BrandId;
            updateToCar.ColorId = car.ColorId;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;
            updateToCar.ModelYear = car.ModelYear;
        }
    }
}
