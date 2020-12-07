using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BakedInHeaven.API.Model;
using BakedInHeaven.API.Context;

namespace BakedInHeaven.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("Products")]
        [HttpGet]
        public List<Product> GetAllProducts()
        {
            using var dbContext = new BakeryDbContext();
            return dbContext.Products.ToList();

        }

        [Route("Products")]
        [HttpPost]
        public bool CreateProducts(Product products)
        {
            using var dbContext = new BakeryDbContext();

            dbContext.Products.Add(products);
            dbContext.SaveChanges();
            

            return true;

        }

        [Route("Products/{id}")]
        [HttpDelete]
        public bool Delete(int id)
        {
            using (BakeryDbContext dbContext = new BakeryDbContext())
            {

                dbContext.Products.Remove(dbContext.Products.FirstOrDefault(e => e.Id == id));
                dbContext.SaveChanges();

                return true;
            }
        }

        [Route("Products/{id}")]
        [HttpPut]
        public bool Update(int id, [FromBody] Product products)
        {
            using (BakeryDbContext dbContext = new BakeryDbContext())
            {
                var a = dbContext.Products.FirstOrDefault(e => e.Id == id);

                a.Id = products.Id;
                a.Name = products.Name;
                a.Quantity = products.Quantity;
                a.Price = products.Price;
                a.WeightInGrams = products.WeightInGrams;
                a.Kcal = products.Kcal;
                a.IsVegiterian = products.IsVegiterian;
                a.IsSpecial = products.IsSpecial;
                a.AvailableDate = products.AvailableDate;


                dbContext.SaveChanges();

                return true;
            }
        }




    }
}