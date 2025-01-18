using YazarKitap.Dal.Context;
using YazarKitap.Entity.Models.Concrete;

namespace YazarKitap.Dal.Repository.Concrete
{
    internal class AuthorRepository : Repository<Author>
    {
        public AuthorRepository(ProjectContext context):base(context) { }
    }
}
