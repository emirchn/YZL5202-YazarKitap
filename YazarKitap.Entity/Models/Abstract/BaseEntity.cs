using YazarKitap.Entity.Enums;

namespace YazarKitap.Entity.Models.Abstract
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; } // ?=nullable
        public DateTime? DeletedDate { get; set; }
        public Statu Statu { get; set; }= Statu.Active;
    }
}
