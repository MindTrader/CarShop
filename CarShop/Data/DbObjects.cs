using CarShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data
{
    public class DbObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.CategoryDb.Any())
                content.CategoryDb.AddRange(Categories.Select(c => c.Value));

            if (!content.CarDb.Any())
            {
                content.AddRange(
                    new Car { Name = "LADA (ВАЗ) Granta I Рестайлинг", ShortDesc = "Luxe Prestige", LongDesc = "Комплектация: Lada Granta седан Luxe Prestige 1.6 106hp 5MT (Лада Гранта Седан).Основные опции: 2021, климат-контроль, аудио, ткань, airbags, ABS, ESP, центральный замок, электропривод стекол, электропривод зеркал, круиз-контроль, датчик дождя, обогрев лобового стекла, обогрев сидений, парктроник, литые диски, R15.Цвет кузова: Голубая планета синий металлик.Обивка сидений ткань.Цвет обивки сидений: темно-серый.", Img = "/img/lada_granta.jpg", Price = 8600, IsFavourite = false, Available = true, Category = Categories["Классические автомобили"] },
                    new Car { Name = "Audi Q7 II (4M) Рестайлинг", ShortDesc = "45 TDI quattro tiptronic", LongDesc = "ляляляляляля", Img = "/img/Audi_Q7.jpg", Price = 45000, IsFavourite = false, Available = true, Category = Categories["Классические автомобили"] },
                    new Car { Name = "Porsche 911 VIII (992) Carrera 4S", ShortDesc = "Sport", LongDesc = "трулулулу", Img = "/img/Porshe.jpg", Price = 60000, IsFavourite = true, Available = true, Category = Categories["Классические автомобили"] },
                    new Car { Name = "Land Rover Range Rover IV", ShortDesc = "Long", LongDesc = "eaasf", Img = "/img/land_rover.jpg", Price = 58000, IsFavourite = false, Available = true, Category = Categories["Классические автомобили"] },
                    new Car { Name = "Renault Sandero II Рестайлинг", ShortDesc = "Stepway Life", LongDesc = "Пассивная безопасность: подушка безопасности водителя; крепление для детского сиденья ISOFIX. Приборы освещения: галогенные фары. Комфорт: атермальное остекление. Охранные системы: иммобилайзер. Запасное колесо: полноразмерное.", Img = "/img/Renault_Sandero_II.png", Price = 11900, IsFavourite = false, Available = false, Category = Categories["Классические автомобили"] },
                    new Car { Name = "BMW 3 серии VII (G2x)", ShortDesc = "320i xDrive M Sport Pure", LongDesc = "Закрывание центрального замка при начале движения; Лазерные фары: адаптивное освещение при повороте, 3 уровня освещения: светодиодные фары ближнего света, светодиодные фары дальнего света с лазерным модулем, светодиодные указатели поворота, светодиодные фары; Светодиодные противотуманные фары; Дневные ходовые огни \"conlight in 0.5 circle shape\"; Внешние зеркала (голубая тонировка) с обогревом и многое другое…", Img = "/img/bmw.jpg", Price = 43593, IsFavourite = true, Available = true, Category = Categories["Классические автомобили"] },
                    new Car { Name = "Tesla Model 3 I", ShortDesc = "Model 3", LongDesc = "Разгон до 100 км/ч за 3,3 сек. Максимальная скорость: 261 км/ч. Батарея: 75 кВт-ч. Запас хода: 567 км по WLTP. Полный привод (по электромотору на каждой оси)", Img = "/img/tesla.jpg", Price = 65535, IsFavourite = true, Available = false, Category = Categories["Электромобили"] },
                    new Car { Name = "Ford Mustang Mach-E I", ShortDesc = "Select", LongDesc = "Mach-E - это Мустанг следующего поколения. Mustang Mach-E оснащен усовершенствованными батареями. Аккумулятор расположен на полу между двумя осями автомобиля – и протестирован при экстремальных температурах до минус 40 градусов. Батареи надежно закреплены внутри водонепроницаемого батарейного отсека, окруженного защитой от аварийного воздействия. Они имеют жидкостное охлаждение для оптимизации производительности в экстремальных погодных условиях и улучшения времени зарядки.", Img = "/img/Mustang.png", Price = 65535, IsFavourite = true, Available = true, Category = Categories["Электромобили"] },
                    new Car { Name = "Audi e-tron I", ShortDesc = "Sport 55 quattro", LongDesc = "Комплектация: Sport 55 quattro; Цвет кузова: Индивидуальная окраска кузова Audi exclusive; Интерьер: серый; Многофункциональный кожаный руль, дизайн «3 спицы», с обогревом; Пакет ионизации и ароматизации воздуха в салоне;Люк; Рейлинги на крыше, черные; Легкосплавные диски, дизайн «5 двойных спиц V», с серыми контрастными элементами, частично полированные, размер 9,5 J x 21, с шинами 285 / 40 R21; Обогрев передних и задних сидений; Пакет безопасности для пассажиров передних и задних сидений и многое другое…", Img = "/img/audi.jpg", Price = 60000, IsFavourite = true, Available = true, Category = Categories["Электромобили"] },
                    new Car { Name = "Chevrolet Bolt", ShortDesc = "PREMIER", LongDesc = "Это первый в мире автомобиль, подходящий и по своим характеристикам, и по цене для массового потребителя. Он был представлен публике в начале 2016 года. Стоимость в самой простой комплектации составила $37,5 тыс., запас хода машины — 322 км. Для сравнения: Nissan Leaf с запасом хода в 170 км на тот момент стоил почти столько же — $34,2 тыс.", Img = "/img/Chevrolet_bolt.png", Price = 30000, IsFavourite = false, Available = true, Category = Categories["Электромобили"] },
                    new Car { Name = "Tesla Model X", ShortDesc = "Long Range Plus", LongDesc = "Коммерческие поставки электрического кроссовера Model X начались в 2015 году, хотя прототип показали еще в 2012 году. Важное отличие машины — двери в форме крыла чайки (сам производитель при этом предпочитает их сравнивать с крыльями сокола, называя Falcon Wing doors).", Img = "/img/Tesla_ModelX.jpg", Price = 60000, IsFavourite = true, Available = true, Category = Categories["Электромобили"] },
                    new Car { Name = "Kia Niro I", ShortDesc = "DeLuxe", LongDesc = "Запас хода этого электрокроссовера, появившегося в продаже в 2018 году, — 240 км или 380 км в зависимости от комплектации.", Img = "/img/Kia_Niro.jpg", Price = 34000, IsFavourite = false, Available = true, Category = Categories["Электромобили"] }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> _categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_categories == null)
                {
                    Category[] list = new Category[]
                    {
                        new Category{CategoryName="Электромобили", Desc="Современный вид транспорта"},
                        new Category{CategoryName="Классические автомобили", Desc="Машины с двигателем внутреннего сгорания"}
                    };

                    _categories = new Dictionary<string, Category>();

                    foreach (Category el in list)
                        _categories.Add(el.CategoryName, el);
                }
                return _categories;
            }
        }
    }
}
