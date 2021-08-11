![GitHub last commit](https://img.shields.io/github/last-commit/MindTrader/CarShop?style=for-the-badge)
![GitHub issues](https://img.shields.io/github/issues/MindTrader/CarShop?style=for-the-badge)
![GitHub repo size](https://img.shields.io/github/repo-size/MindTrader/CarShop?style=for-the-badge)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/MindTrader/CarShop?style=for-the-badge)
![GitHub language count](https://img.shields.io/github/languages/count/MindTrader/CarShop?style=for-the-badge)
![GitHub top language](https://img.shields.io/github/languages/top/MindTrader/CarShop?style=for-the-badge)

# CarShop
Данное веб приложение создано для учебных целей, направлено на изучение и работу со следующими технологиями: MVC, Entity Framework (Code-First), Bootstrap...

Приложение представляет собой интернет магазин автомобилей. Все автомобили загружаются из базы данных с помощью Entity Framework. Есть возможность добавить любой автомобиль, или несколько автомобилей в корзину с дальнейшим оформлением заказа.

Целевая платформа - .Net Core 2.1

## Описание работы приложения
При запуске приложения, на главной странице сайта вы увидите перечень "лучших" автомобилей (автомобили из БД, у которых поле `IsFavourite = true`)
<p align="center"><img src="ScreenShots/main.jpg" alt="Главная страница" title="Главная страница"/></p>

Сверху на странице можно заметить навигационный раздел, откуда вы можете переместиться на вкладки со всеми имеющимися автомобилями в наличии:
<p align="center"><img src="ScreenShots/allCars.jpg" alt="Все автомобили" title="Все автомобили"/></p>

или посмотреть автомобили с ДВС:
<p align="center"><img src="ScreenShots/fuel.jpg" alt="Автомобили с ДВС" title="Автомобили с ДВС"/></p>

или же автомобили с электро двигателем:
<p align="center"><img src="ScreenShots/electro.jpg" alt="Электромобили" title="Электромобили"/></p>

Под каждым автомобилем есть кнопка "Add To Cart" - с помощью неё вы можете добавить любой автомобиль в корзину для дальнейшей покупки.

После добавления в корзину вас автоматически перенаправит на страницу корзины. Там вы можете оформить свой заказ, щёлкнув на кнопку "Оплатить", либо продолжить свои покупки далее, кликнув на любую из ссылок навигационного раздела сверху
<p align="center"><img src="ScreenShots/cart.jpg" alt="Корзина" title="Корзина"/></p>

После нажатия на кнопку "Оплатить", вас перенаправит на страницу оформления заказа. Она представляет собой форму с проверкой ввода полей. Если информация будет пропущена, или введена некорректно, то заявка не будет отправлена до исправления ваших недочётов:
<p align="center"><img src="ScreenShots/orderCompleteErr.jpg" alt="Завершение оформления заказа с ошибкой" title="Завершение оформления заказа с ошибкой"/></p>

Если введённая вами информация корректна и соответствует ожиданиям полей формы, то оформление заказа завершится, а вы будете перенаправлены на другую страницу
<p align="center"><img src="ScreenShots/orderComplete.jpg" alt="Завершение оформления заказа" title="Завершение оформления заказа"/></p>
<p align="center"><img src="ScreenShots/final.jpg" alt="Заказ оформлен!" title="Заказ оформлен!"/></p>
