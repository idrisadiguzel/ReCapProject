using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{


    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarName= "x5", BrandId = 1, ColorId=2, Id= 1, DailyPrice= 1800, ModelYear= 2012, Description= "On numara araba"},
                new Car{CarName= "A4", BrandId = 2, ColorId=4, Id= 2, DailyPrice= 8100, ModelYear= 2033, Description= "On numara araba"},
                new Car{CarName= "a2", BrandId = 2, ColorId=1, Id= 3, DailyPrice= 8200, ModelYear= 2023, Description= "On numara araba"},
                new Car{CarName= "x1", BrandId = 1, ColorId=2, Id= 4, DailyPrice= 8400, ModelYear= 2022, Description= "On numara araba"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.Id== car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c=> c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
