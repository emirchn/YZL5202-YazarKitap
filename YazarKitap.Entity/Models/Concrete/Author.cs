using YazarKitap.Entity.Models.Abstract;

namespace YazarKitap.Entity.Models.Concrete
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Biography { get; set; }
        public List<Book> AuthorsBook { get; set; }
        public Author() 
        { 
            AuthorsBook = new List<Book>();
        }
    }
}