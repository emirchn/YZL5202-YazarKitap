using Microsoft.EntityFrameworkCore;
using YazarKitap.Dal.Configs;
using YazarKitap.Entity.Models.Concrete;

namespace YazarKitap.Dal.Context
{
    public class ProjectContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3V5LOEN\\MSSQLSERVER01;Database=KitapYazar5202;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Book>().HasOne(a => a.BookAuthor).WithMany(a => a.AuthorsBook).HasForeignKey(a => a.AuthorId);

            modelBuilder.ApplyConfiguration(new AuthorConfig());
            modelBuilder.ApplyConfiguration(new BookConfig());
        }


    }
}