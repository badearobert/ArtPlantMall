using ArtPlantMall.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ArtPlantMall.Views.Templates
{
    public class BasketItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate PlantTemplate { get; set; }
        public DataTemplate DeliveryTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((BasketItem)item).BasketItemType == BasketItemType.Plant ?
                PlantTemplate :
                DeliveryTemplate;
        }
    }
}
