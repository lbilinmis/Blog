using Blog.Entities.Concrete;
using Blog.Shared.DataAccess.Abstract;
using Blog.Shared.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfRoleRepository : EfEntityRepositoryBase<Role>, IEntityRepository<Role>
    {
        public EfRoleRepository(DbContext context) : base(context)
        {
        }
    }
}
