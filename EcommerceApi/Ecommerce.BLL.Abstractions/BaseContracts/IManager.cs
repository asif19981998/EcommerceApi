using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL.Abstractions.BaseContracts
{
    public interface IManager<T> where T:class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
        T GetById(int id);
        ICollection<T> GetAll();
    }
}
