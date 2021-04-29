using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarShop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent _appDBContent;
        public ShopCart(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public string ShopCartId { get; set; }
        public List<ShopCartItem> CartItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var contex = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(contex) { ShopCartId = shopCartId };
        }

        public void AddToCart(Car carItem)
        {
            _appDBContent.ShopCartItemDb.Add(new ShopCartItem { ShopCartId = this.ShopCartId, CarItem = carItem, Price = carItem.Price });
            _appDBContent.SaveChanges();
        }

        public void RemoveAllFromCart()
        {
            foreach (ShopCartItem car in _appDBContent.ShopCartItemDb)
                _appDBContent.ShopCartItemDb.Remove(car);

            _appDBContent.SaveChanges();
        }

        public List<ShopCartItem> GetCartItems()
        {
            return _appDBContent.ShopCartItemDb.Where(c => c.ShopCartId == this.ShopCartId).Include(s => s.CarItem).ToList();
        }
    }
}
