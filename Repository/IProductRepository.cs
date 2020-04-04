using System.Collections.Generic;
using ProductMicroService.Models;

namespace ProductMicroService.Repository
{
    public interface IProductRepository
    {
        public void DeleteProduct(int productId);
        public void InsertProduct(Product product);
        public void UpdateProduct(Product product);
        public IEnumerable<Product> GetProducts();
    }
}
