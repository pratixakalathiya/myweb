using MyApp.Models;

namespace MyApp.DataAccessLayer.Infrastrucutre.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
