using MyApp.Models;

namespace MyApp.DataAccessLayer.Infrastrucutre.IRepository
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        void Update(OrderDetail orderDetail);
    }
}
