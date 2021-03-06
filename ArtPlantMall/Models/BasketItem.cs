﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArtPlantMall.Models
{
    public enum BasketItemType
    {
        Plant,
        Delivery
    }
    public class BasketItem
    {
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public decimal UnitPrice { get; set; }
        public BasketItemType BasketItemType{ get; set; }
    }
}
