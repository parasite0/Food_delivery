﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodClass
{
    public class Food
    {
        /// <summary>
        /// Дата заполнения
        /// </summary>
        public DateTime Filled { get; set; }
        /// <summary>
        /// ФИО заказчика
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Адресс доставки
        /// </summary>
        public List<WayPoint> WayPoints { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
        /// <summary>
        /// Заказанные блюда
        /// </summary>
        public List<DishesType> Dishes { get; set; }
        /// <summary>
        /// Номер телефона заказчика
        /// </summary>
        public int PhoneNumber { get; set; }
        /// <summary>
        /// К какому времени доставить
        /// </summary>
        public DateTime DeliveryTime { get; set; }
    }
    public enum Currency
    {
        Rubles
    }
    public class WayPoint
    {
        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Номер дома
        /// </summary>
        public int HouseNumber { get; set; }
        /// <summary>
        /// Номер квартиры
        /// </summary>
        public int ApartmentNumber { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Street, HouseNumber, ApartmentNumber);
        }

        public WayPoint Clone()
        {
            return new WayPoint { Street = Street, HouseNumber = HouseNumber, ApartmentNumber = ApartmentNumber };
        }

    }
    public class DishesType
    {
        public DishesMenu Menu { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Menu);
        }

        public DishesType Clone()
        {
            return new DishesType { Menu = Menu };
        }
    }
    public enum DishesMenu
    {
        Pizza,
        Sushi,
        Borscht,
        Barbecue,
        Chicken,
        Salad,
        Kebab,
        Nuggets,
        Humburger,
        Potatoes
    }
}