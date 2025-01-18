using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using YazarKitap.Dal.Context;
using YazarKitap.Dal.Repository.Abstract;
using YazarKitap.Entity.Enums;
using YazarKitap.Entity.Models.Abstract;

namespace YazarKitap.Dal.Repository.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ProjectContext _context;
        private readonly DbSet<T> _table;


        public Repository(ProjectContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }
        public T Add(T entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public T Delete(T entity)
        {
            entity.Statu = Statu.Deleted;
            entity.DeletedDate = DateTime.Now;
            _table.Update(entity);
            _context.SaveChanges();
            return entity;
        }


        public T Get(int id)
        {
            return _table.Find(id);
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression = null)
        {
            if(expression is null) return _table.ToList();
            else return _table.Where(expression).ToList();
        }

        public T Update(T entity)
        {
            entity.Statu = Statu.Modified;
            entity.ModifiedDate = DateTime.Now;
            _table.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}