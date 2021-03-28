using Ecommerce.BLL.Abstractions.EntityManagerContracts;
using Ecommerce.BLL.Base;
using Ecommerce.Models.EntityModels;
using Ecommerce.Repositories.Abstractions.EntityContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL.EntityManager
{
    public class ShopManger:Manager<Shop>,IShopManager
    {
        private IShopRepository _repository;
        public ShopManger(IShopRepository repository):base(repository)
        {
            _repository = repository;
        }
    }
}
