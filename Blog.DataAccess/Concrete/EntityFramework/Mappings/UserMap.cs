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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(40);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(40);
            //burada email ve username bilgileri uniq olmalıdır.
            builder.Property(x => x.Email).IsRequired().HasMaxLength(140);
            builder.HasIndex(x => x.Email).IsUnique();

            builder.Property(x => x.UserName).IsRequired().HasMaxLength(40);
            builder.HasIndex(x => x.UserName).IsUnique();

            builder.Property(x => x.PasswordHash).IsRequired().HasColumnType("VARBINARY(500)");
            builder.Property(x => x.Picture).IsRequired().HasMaxLength(140);
            builder.Property(x => x.Description).HasMaxLength(240);

            builder.Property(x => x.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.ModifiedByName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

            builder.HasOne<Role>(x => x.Role)
                .WithMany(u => u.Users)
                .HasForeignKey(x => x.RoleId);

            builder.ToTable("Users");


        }
    }
}
