using MyApp.Models;

namespace MyApp.DataAccessLayer.Infrastrucutre.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
