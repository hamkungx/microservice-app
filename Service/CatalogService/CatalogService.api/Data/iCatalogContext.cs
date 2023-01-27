using CatalogService.api.Entities;
using MongoDB.Driver;

namespace CatalogService.api.Data

{
    public interface ICatalogContext
    {
        public IMongoCollection<Product> Products { get; }

    }
}
