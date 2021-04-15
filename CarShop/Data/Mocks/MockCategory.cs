using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data.Mocks
{
    public class MockCategory : ICarsCategories
    {
        public IEnumerable<Category> AllCategorites
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName="Электромобили", Desc="Современный вид транспорта"},
                    new Category{CategoryName="Классические автомобили", Desc="Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
