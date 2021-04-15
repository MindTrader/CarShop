using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent _appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => _appDBContent.CarDb.Include(c => c.Category);

        public IEnumerable<Car> GetFavCars => _appDBContent.CarDb.Where(p => p.IsFavourite).Include(c => c.Category);

        public Car GetObjectCar(int carId) => _appDBContent.CarDb.FirstOrDefault(p => p.Id == carId);
    }
}
