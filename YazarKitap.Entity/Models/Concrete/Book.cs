using YazarKitap.Entity.Models.Abstract;

namespace YazarKitap.Entity.Models.Concrete
{
    public class Book : BaseEntity
    {
        public string BookName { get; set; }
        public int PageNumber { get; set; }
        public string BookSummary { get; set; }
        public int AuthorId { get; set; }
        public Author BookAuthor { get; set; }
    }
}
