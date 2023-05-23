using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Content).HasColumnType("nvarchar(MAX)");
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.Meta_Author).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Meta_Description).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Meta_Keyword).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Meta_Tags).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Meta_Title).IsRequired().HasMaxLength(50);
            builder.Property(x => x.ViewsCount).IsRequired();
            builder.Property(x => x.CommentCount).IsRequired();
            builder.Property(x => x.Thumbnail).IsRequired().HasMaxLength(250);

            builder.Property(x => x.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.ModifiedByName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.Note).HasMaxLength(1000);

            builder
                .HasOne<Category>(x => x.Category)
                .WithMany(c => c.Articles)
                .HasForeignKey(x => x.CategoryId);

            builder.HasOne<User>(x=>x.User)
                .WithMany(u=>u.Articles)
                .HasForeignKey(x => x.UserId);

            builder.ToTable("Articles");

        }
    }
}
