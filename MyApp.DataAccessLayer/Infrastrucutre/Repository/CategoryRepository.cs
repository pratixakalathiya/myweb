using MyApp.DataAccessLayer.Infrastrucutre.IRepository;
using MyApp.Models;

namespace MyApp.DataAccessLayer.Infrastrucutre.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Category category)
        {
            var CategoryDB = _context.Categories.FirstOrDefault(x => x.Id == category.Id);   
            if (CategoryDB != null) 
            { 
                CategoryDB.Name = CategoryDB.Name;
                CategoryDB.DisplayOrder = CategoryDB.DisplayOrder;
            }
        }
    }
}
