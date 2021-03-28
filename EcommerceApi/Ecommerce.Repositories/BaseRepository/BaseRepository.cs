using Ecommerce.Repositories.Abstractions.BaseContracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        DbContext _dbContext;
        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;

        }
        DbSet<T> Table
        {
            get { return _dbContext.Set<T>(); }
        }
        public virtual void Add(T entity)
        {
            Table.Add(entity);
            SaveChanges();
            
        }

        public virtual ICollection<T> GetAll()
        {
           return Table.ToList();
        }

        public virtual T GetById(int id)
        {
            return Table.Find(id);
        }

        public virtual void Remove(T entity)
        {
            Table.Remove(entity);
            SaveChanges();

        }

        public virtual void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            SaveChanges();
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
