using MongoDB.Driver;
using Catalogo.API.Entities;

namespace Catalogo.API.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}