using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using CarShop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data.Models;

namespace CarShop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategories _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategories iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            IEnumerable<Car> cars = null;
            string curCategory = "Все автомобили";

            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(p => p.Id);
            }
            else if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
            {
                cars = _allCars.Cars.Where(p => p.Category.CategoryName.Equals("Электромобили")).OrderBy(p => p.Id);
                curCategory = "Электромобили";
            }
            else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
            {
                cars = _allCars.Cars.Where(p => p.Category.CategoryName.Equals("Классические автомобили")).OrderBy(p => p.Id);
                curCategory = "Классические автомобили";
            }

            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel carObj = new CarsListViewModel
            {
                AllCars = cars,
                CurrCategory = curCategory
            };

            return View(carObj);
        }
    }
}
