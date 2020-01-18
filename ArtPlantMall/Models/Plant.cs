using System;
using System.Collections.Generic;
using System.Text;

namespace ArtPlantMall.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
