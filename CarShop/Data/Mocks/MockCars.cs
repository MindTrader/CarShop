using CarShop.Data.Interfaces;
using CarShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategories _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car{Name="LADA (ВАЗ) Granta I Рестайлинг", ShortDesc="Комплектация Luxe Prestige", LongDesc="Комплектация: Lada Granta седан Luxe Prestige 1.6 106hp 5MT (Лада Гранта Седан).Основные опции: 2021, климат-контроль, аудио, ткань, airbags, ABS, ESP, центральный замок, электропривод стекол, электропривод зеркал, круиз-контроль, датчик дождя, обогрев лобового стекла, обогрев сидений, парктроник, литые диски, R15.Цвет кузова: Голубая планета синий металлик.Обивка сидений ткань.Цвет обивки сидений: темно-серый.", Img="/img/lada_granta.jpg", Price=8600, IsFavourite=false, Available=true, Category=_categoryCars.AllCategorites.Last()},
                    new Car{Name="Renault Sandero II Рестайлинг", ShortDesc="Комплектация Stepway Life", LongDesc="Пассивная безопасность: подушка безопасности водителя; крепление для детского сиденья ISOFIX. Приборы освещения: галогенные фары. Комфорт: атермальное остекление. Охранные системы: иммобилайзер. Запасное колесо: полноразмерное.", Img="/img/Renault_Sandero_II.png", Price=11900, IsFavourite=false, Available=false, Category=_categoryCars.AllCategorites.Last()},
                    new Car{Name="BMW 3 серии VII (G2x)", ShortDesc="Комплектация 320i xDrive M Sport Pure", LongDesc="Закрывание центрального замка при начале движения; Лазерные фары: адаптивное освещение при повороте, 3 уровня освещения: светодиодные фары ближнего света, светодиодные фары дальнего света с лазерным модулем, светодиодные указатели поворота, светодиодные фары; Светодиодные противотуманные фары; Дневные ходовые огни \"conlight in 0.5 circle shape\"; Внешние зеркала (голубая тонировка) с обогревом и многое другое…", Img="/img/bmw.jpg", Price=43593, IsFavourite=true, Available=true, Category=_categoryCars.AllCategorites.Last()},
                    new Car{Name="Tesla Model 3 I", ShortDesc="Комплектация Model 3", LongDesc="Разгон до 100 км/ч за 3,3 сек. Максимальная скорость: 261 км/ч. Батарея: 75 кВт-ч. Запас хода: 567 км по WLTP. Полный привод (по электромотору на каждой оси)", Img="/img/tesla.jpg", Price=65535, IsFavourite=true, Available=false, Category=_categoryCars.AllCategorites.First()},
                    new Car{Name="Ford Mustang Mach-E I", ShortDesc="Комплектация Select", LongDesc="Mach-E - это Мустанг следующего поколения. Mustang Mach-E оснащен усовершенствованными батареями. Аккумулятор расположен на полу между двумя осями автомобиля – и протестирован при экстремальных температурах до минус 40 градусов. Батареи надежно закреплены внутри водонепроницаемого батарейного отсека, окруженного защитой от аварийного воздействия. Они имеют жидкостное охлаждение для оптимизации производительности в экстремальных погодных условиях и улучшения времени зарядки.", Img="/img/Mustang.png", Price=65535, IsFavourite=true, Available=true, Category=_categoryCars.AllCategorites.First()},
                    new Car{Name="Audi e-tron I", ShortDesc="Комплектация Sport 55 quattro", LongDesc="Комплектация: Sport 55 quattro; Цвет кузова: Индивидуальная окраска кузова Audi exclusive; Интерьер: серый; Многофункциональный кожаный руль, дизайн «3 спицы», с обогревом; Пакет ионизации и ароматизации воздуха в салоне;Люк; Рейлинги на крыше, черные; Легкосплавные диски, дизайн «5 двойных спиц V», с серыми контрастными элементами, частично полированные, размер 9,5 J x 21, с шинами 285 / 40 R21; Обогрев передних и задних сидений; Пакет безопасности для пассажиров передних и задних сидений и многое другое…", Img="/img/audi.jpg", Price=60000, IsFavourite=true, Available=true, Category=_categoryCars.AllCategorites.First()}
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get;}

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
