using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);

            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();

            }
        }

        public void Update(Car entity)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
