using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using Catalogo.API.Entities;

namespace Catalogo.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(productCollection => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "35j74jkj74k758ç6",
                    Name = "Acer Aspire 5",
                    Description = "Text",
                    Image = "product-1.png",
                    Price = 1050.00M,
                    Category = "Notebook"
                },
                new Product()
                {
                    Id = "klnjkl547nj7k",
                    Name = "Moto Z3 Play",
                    Description = "Text",
                    Image = "product-2.png",
                    Price = 2090.00M,
                    Category = "Smart Phone"
                }
            };
        }
    }
}