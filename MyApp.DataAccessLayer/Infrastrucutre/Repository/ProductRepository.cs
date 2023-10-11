using MyApp.DataAccessLayer.Infrastrucutre.IRepository;
using MyApp.Models;

namespace MyApp.DataAccessLayer.Infrastrucutre.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Product product)
        {
            var productDb = _context.Products.FirstOrDefault(x => x.Id == product.Id);
            if (productDb != null)
            {
                productDb.Name = productDb.Name;
                productDb.Description = productDb.Description;
                productDb.Price = productDb.Price;
                if(product.ImageUrl != null)
                {
                    productDb.ImageUrl = product.ImageUrl;
                }
            }
        }
    }
}
