using System.Linq.Expressions;
using YazarKitap.Entity.Models.Abstract;

namespace YazarKitap.Dal.Repository.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        // crud : create , read , delete , read denilen işlemler yaptırılır.

        public T Add(T entity);
        public T Update(T entity);
        public T Delete(T entity);
        //public List<T> GetAll();
        public List<T> GetAll(Expression<Func<T,bool>> expression=null); // expression sağlayanları getirir.
        public T Get(int id); // tek nesne döner
    }
}
