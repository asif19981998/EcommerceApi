using Ecommerce.Models.EntityModels;
using Ecommerce.Repositories.Abstractions.BaseContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repositories.Abstractions.EntityContracts
{
    public interface IShopRepository:IBaseRepository<Shop>
    {
    }
}
