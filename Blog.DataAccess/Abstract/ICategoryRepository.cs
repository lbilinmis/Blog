﻿using Blog.Entities.Concrete;
using Blog.Shared.DataAccess.Abstract;

namespace Blog.DataAccess.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
    }
}
