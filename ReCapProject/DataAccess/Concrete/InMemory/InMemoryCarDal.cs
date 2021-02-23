using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        private int brandId;

        public InMemoryCarDal()
        {
            _car = new List<Car> { new Car { Id = 1, BrandId = 1, ColorId = 1,ModelYear = "2005", DailyPrice = 90,Description= "RELIABILITY AND PLEASURE OF RENT A CAR KAZANCI RENT A CAR " } };
            _car = new List<Car> { new Car { Id = 2, BrandId = 2, ColorId = 2, ModelYear = "2007", DailyPrice = 100, Description = "RELIABILITY AND PLEASURE OF RENT A CAR KAZANCI RENT A CAR " } };
            _car = new List<Car> { new Car { Id = 3, BrandId = 3, ColorId = 3, ModelYear = "2020", DailyPrice = 250, Description = "RELIABILITY AND PLEASURE OF RENT A CAR KAZANCI RENT A CAR " } };
            _car = new List<Car> { new Car { Id = 4, BrandId = 4, ColorId = 4, ModelYear = "2013", DailyPrice = 200, Description = "RELIABILITY AND PLEASURE OF RENT A CAR KAZANCI RENT A CAR " } };
            _car = new List<Car> { new Car { Id = 5, BrandId = 5, ColorId = 5, ModelYear = "2011", DailyPrice = 200, Description = "RELIABILITY AND PLEASURE OF RENT A CAR KAZANCI RENT A CAR " } };

        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }
        public List<Car> GetById()
        {
            return _car.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
        }
    }
}
