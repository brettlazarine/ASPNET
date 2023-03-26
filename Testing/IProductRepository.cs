using Org.BouncyCastle.Asn1.BC;
using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
    }
}
