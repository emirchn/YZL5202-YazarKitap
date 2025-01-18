using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YazarKitap.Entity.Models.Concrete;

namespace YazarKitap.Dal.Configs
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BookSummary).IsRequired(false).HasMaxLength(150);
            builder.HasOne(x=>x.BookAuthor).WithMany(x=>x.AuthorsBook).HasForeignKey(x=>x.AuthorId);
        }
    }
}