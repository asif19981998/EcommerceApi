using Ecommerce.BLL.Abstractions.BaseContracts;
using Ecommerce.Repositories.Abstractions.BaseContracts;
using Ecommerce.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Repositories.Abstractions.BaseContracts;
namespace Ecommerce.BLL.Base
{
    public class Manager<T> : IManager<T> where T : class
    {
        IBaseRepository<T> _repository;
        public Manager(IBaseRepository<T> repository)
        {
            _repository = repository;
        }
        public virtual bool Add(T entity)
        {
            _repository.Add(entity);
            return true;
            
        }

        public virtual ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public virtual bool Remove(T entity)
        {
            _repository.Remove(entity);
            return true;
        }

        public virtual bool Update(T entity)
        {
            _repository.Update(entity);
            return true;
        }
    }
}
