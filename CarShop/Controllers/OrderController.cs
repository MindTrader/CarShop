using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders _allOrders;
        private readonly ShopCart _shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            _allOrders = allOrders;
            _shopCart = shopCart;
        }
        public IActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            _shopCart.CartItems = _shopCart.GetCartItems();

            if (_shopCart.CartItems.Count == 0)
            {
                ModelState.AddModelError("", "Корзина пуста. Добавьте товара для оплаты");
            }

            if(ModelState.IsValid)
            {
                _allOrders.CreateOrder(order);
                return RedirectToAction("Complete");
            }

                return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            _shopCart.RemoveAllFromCart();
            return View();
        }
    }
}