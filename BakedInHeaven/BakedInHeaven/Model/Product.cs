using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakedInHeaven.API.Context;

namespace BakedInHeaven.API.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float WeightInGrams { get; set; }
        public float Kcal { get; set; }
        public bool IsVegiterian { get; set; }
        public bool IsSpecial { get; set; }
        public DateTime AvailableDate { get; set; }
    }
}
