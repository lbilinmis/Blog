using Blog.Entities.Concrete;
using Blog.Shared.DataAccess.Abstract;
using Blog.Shared.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category>, IEntityRepository<Category>
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
