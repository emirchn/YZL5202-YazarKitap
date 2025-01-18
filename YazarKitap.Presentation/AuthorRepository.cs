using YazarKitap.Dal.Context;

namespace YazarKitap.Presentation
{
    internal class AuthorRepository
    {
        private ProjectContext context;

        public AuthorRepository(ProjectContext context)
        {
            this.context = context;
        }
    }
}