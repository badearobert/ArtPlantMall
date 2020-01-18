using ArtPlantMall.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtPlantMall.Services
{
    public class BasketService
    {
        private static BasketService _instance;
        public static BasketService Instance
        {
            get
            {
                if (_instance == null) _instance = new BasketService();
                return _instance;
            }
        }
        public List<BasketItem> GetActualBasket()
        {
            return new List<BasketItem>
            {
                new BasketItem { BasketItemType = BasketItemType.Plant, ProductName = "Sebastian", ProductImage = "sebastian.png", Quantity = 1, UnitPrice = 0 },
                new BasketItem { BasketItemType = BasketItemType.Plant, ProductName = "Angelica", ProductImage = "angelica.png", Quantity = 1, UnitPrice = 0 },
                new BasketItem { BasketItemType = BasketItemType.Plant, ProductName = "Samantha", ProductImage = "samantha.png", Quantity = 1, UnitPrice = 0 },
                new BasketItem { BasketItemType = BasketItemType.Delivery, ProductName = "Delivery", Quantity = 1, UnitPrice = 0 },
            };
        }
    }
}
