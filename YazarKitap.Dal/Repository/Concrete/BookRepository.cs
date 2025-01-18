using YazarKitap.Dal.Context;
using YazarKitap.Entity.Models.Concrete;

namespace YazarKitap.Dal.Repository.Concrete
{
    public class BookRepository : Repository<Book>
    {
        public BookRepository(ProjectContext context) : base(context) { }
    }
}
