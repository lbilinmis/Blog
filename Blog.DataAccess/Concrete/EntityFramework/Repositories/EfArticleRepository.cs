using Blog.Entities.Concrete;
using Blog.Shared.DataAccess.Abstract;
using Blog.Shared.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfArticleRepository : EfEntityRepositoryBase<Article>, IEntityRepository<Article>
    {
        public EfArticleRepository(DbContext context) : base(context)
        {
        }
    }
}
