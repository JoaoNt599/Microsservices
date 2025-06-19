using System;
using MongoDB.Driver;
using Catalogo.API.Entities;
using Microsoft.Extensions.Configuration;


namespace Catalogo.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        private readonly IMongoDatabase _database;
        public IMongoCollection<Product> Products { get; }
        public CatalogContext(IConfiguration configuration)
        {
            var cliente = new MongoClient(configuration.GetValue<string>
                ("DatabaseSettings:ConnectionString"));

            var _database = cliente.GetDatabase(configuration.GetValue<string>
                ("DatabaseSettings:DatabaseName"));

            Products = _database.GetCollection<Product>(configuration.GetValue<string>
                ("DatabaseSettings:CollectionName"));

            CatalogContextSeed.SeedData(Products);
        }
        // public IMongoCollection<Product> Products => throw new NotImplementedException();
    }
}