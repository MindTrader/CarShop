using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data.Interfaces;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRep;

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult Index()
        {
            HomeViewModel homeCars = new HomeViewModel
            {
                FavCars = _carRep.GetFavCars
            };
            return View(homeCars);
        }
    }
}