using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly AppDBContent _appDBContent;
        private readonly ShopCart _shopCart;

        public OrderRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            _appDBContent = appDBContent;
            _shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _appDBContent.OrderDb.Add(order);

            List<ShopCartItem> Cartitems = _shopCart.CartItems;

            foreach (ShopCartItem cartItem in Cartitems)
            {
                OrderDetail orderDetail = new OrderDetail
                {
                    CarId = cartItem.CarItem.Id,
                    OrderId = order.Id,
                    Price = cartItem.CarItem.Price
                };
                _appDBContent.OrderDetailDb.Add(orderDetail);
            }
            _appDBContent.SaveChanges();
        }
    }
}
