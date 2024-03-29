﻿using CarShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) { }

        public DbSet<Car> CarDb { get; set; }
        public DbSet<Category> CategoryDb { get; set; }
        public DbSet<ShopCartItem> ShopCartItemDb { get; set; }
        public DbSet<Order> OrderDb { get; set; }
        public DbSet<OrderDetail> OrderDetailDb { get; set; }
    }
}
