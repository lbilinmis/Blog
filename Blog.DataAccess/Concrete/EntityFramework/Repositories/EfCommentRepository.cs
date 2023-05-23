using Blog.Entities.Concrete;
using Blog.Shared.DataAccess.Abstract;
using Blog.Shared.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCommentRepository : EfEntityRepositoryBase<Comment>, IEntityRepository<Comment>
    {
        public EfCommentRepository(DbContext context) : base(context)
        {
        }
    }
}
