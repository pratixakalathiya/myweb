using MyApp.DataAccessLayer.Infrastrucutre.IRepository;
using MyApp.Models;

namespace MyApp.DataAccessLayer.Infrastrucutre.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private ApplicationDbContext _context;
        public OrderHeaderRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void PaymentStatus(int Id, string SessionId, string? paymentIntentId)
        {
            var orderHeader = _context.OrderHeaders.FirstOrDefault(x => x.Id == Id);
            orderHeader.DateOfPayment = DateTime.Now;
            orderHeader.PaymentIntentId = paymentIntentId;
            orderHeader.SessionId = SessionId;
        }

        public void Update(OrderHeader orderHeader)
        {
            _context.OrderHeaders.Update(orderHeader);
            //var CategoryDB = _context.Categories.FirstOrDefault(x => x.Id == category.Id);   
            //if (CategoryDB != null) 
            //{ 
            //    CategoryDB.Name = CategoryDB.Name;
            //    CategoryDB.DisplayOrder = CategoryDB.DisplayOrder;
            //}
        }

        public void updateStatus(int id, string orderStatus, string? paymentStatus = null)
        {
            var order = _context.OrderHeaders.FirstOrDefault(x => x.Id == id);
            if (order != null)
            {
                order.OrderStatus = orderStatus;
            }
            if (paymentStatus != null)
            {
                order.PaymentStatus = paymentStatus;
            }
        }
    }
    
}
