using YazarKitap.Dal.Context;

namespace YazarKitap.Presentation
{
    public class AuthorRepository
    {
        private ProjectContext context;

        public AuthorRepository(ProjectContext context)
        {
            this.context = context;
        }
    }
}