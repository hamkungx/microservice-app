using CatalogService.api.Entities;
using MongoDB.Driver;

namespace CatalogService.api.Data

{
    public interface iCatalogContext
    {
        public IMongoCollection<Product> Products { get; }

    }
}
