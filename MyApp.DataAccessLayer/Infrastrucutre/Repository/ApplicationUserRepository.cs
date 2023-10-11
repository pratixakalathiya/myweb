using MyApp.DataAccessLayer.Infrastrucutre.IRepository;
using MyApp.Models;

namespace MyApp.DataAccessLayer.Infrastrucutre.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUser
    {
        private ApplicationDbContext _context;
        public ApplicationUserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
