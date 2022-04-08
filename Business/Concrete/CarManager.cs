using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length>=2 && car.DailyPrice>0 )
            {
                _carDal.Add(car);

            }
            else {

                if (car.CarName.Length < 2)
                {
                    Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır.");
                }
                else
                {
                    Console.WriteLine("Araba günlük fiyatı 0'dan büyük olmalıdır.");

                }

            }
        }

        public List<Car> GetAll()
        {
            
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
       
        }
        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);

        }


    }
}
