using MyApp.Models;

namespace MyApp.DataAccessLayer.Infrastrucutre.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader orderHeader);
        void updateStatus(int Id, string orderStatus, string? paymentStatus=null);//status for order like confrim,padding,dne like this
        void PaymentStatus(int Id, string SessionId, string? paymentIntentId);
    }
}
