using Blog.DataAccess.Abstract;
using Blog.DataAccess.Abstract.UnitOfWork;
using Blog.DataAccess.Concrete.EntityFramework.Contexts;
using Blog.DataAccess.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Concrete.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogDbContext _context;

        private EfArticleRepository _articleRepository;
        private EfCategoryRepository _categoryRepository;
        private EfCommentRepository _commentRepository;
        private EfRoleRepository _roleRepository;
        private EfUserRepository _userRepository;

        public UnitOfWork(BlogDbContext context)
        {
            _context = context;
        }

        public IArticleRepository Articles => (IArticleRepository)(_articleRepository ?? new EfArticleRepository(_context));

        public ICategoryRepository Categories => (ICategoryRepository)(_categoryRepository ?? new EfCategoryRepository(_context));

        public ICommentRepository Comments => (ICommentRepository)(_commentRepository ?? new EfCommentRepository(_context));

        public IRoleRepository Roles => (IRoleRepository)(_roleRepository ?? new EfRoleRepository(_context));

        public IUserRepository Users => (IUserRepository)(_userRepository ?? new EfUserRepository(_context));

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
