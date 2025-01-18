using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YazarKitap.Entity.Models.Concrete;

namespace YazarKitap.Dal.Configs
{
    internal class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(a => a.LastName).IsRequired(true);
            builder.Property(a => a.FirstName).IsRequired(true).HasMaxLength(200);
            builder.Property(a =>a.Biography).IsRequired(false);
        }
    }
}
