using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CarShop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCars _carRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetCartItems();
            _shopCart.CartItems = items;

            var obj = new ShopCartViewModel { ShopCartItem = _shopCart };
            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(i => i.Id == id);
            if (item != null)
                _shopCart.AddToCart(item);
            return RedirectToAction("Index");
        }
    }
}
