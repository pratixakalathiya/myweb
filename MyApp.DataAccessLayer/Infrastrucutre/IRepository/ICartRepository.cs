using MyApp.Models;

namespace MyApp.DataAccessLayer.Infrastrucutre.IRepository
{
    public interface ICartRepository : IRepository<Cart>
    {
        int IncrementCartItem(Cart cart, int count);
        int DecrementCartItem(Cart cart, int count);
    }
}
