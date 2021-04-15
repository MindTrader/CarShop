using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace CarShop.Data.Repository
{
    public class CategoryRepository : ICarsCategories
    {
        private readonly AppDBContent _appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategorites => _appDBContent.CategoryDb;
    }
}
