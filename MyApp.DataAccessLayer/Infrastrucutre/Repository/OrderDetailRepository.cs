using MyApp.DataAccessLayer.Infrastrucutre.IRepository;
using MyApp.Models;

namespace MyApp.DataAccessLayer.Infrastrucutre.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext _context;
        public OrderDetailRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(OrderDetail orderDetail)
        {
            _context.OrderDetails.Update(orderDetail);
            //var CategoryDB = _context.Categories.FirstOrDefault(x => x.Id == category.Id);   
            //if (CategoryDB != null) 
            //{ 
            //    CategoryDB.Name = CategoryDB.Name;
            //    CategoryDB.DisplayOrder = CategoryDB.DisplayOrder;
            //}
        }
    }
}
