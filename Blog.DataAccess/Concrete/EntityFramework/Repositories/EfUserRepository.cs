using Blog.Entities.Concrete;
using Blog.Shared.DataAccess.Abstract;
using Blog.Shared.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfUserRepository : EfEntityRepositoryBase<User>, IEntityRepository<User>
    {
        public EfUserRepository(DbContext context) : base(context)
        {
        }
    }
}
