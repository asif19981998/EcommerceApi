using Ecommerce.BLL.Abstractions.EntityManager;
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
    
    public class ProductManager:Manager<Product>,IProductManager
    {
        private IProuductRespository _repository;
        public ProductManager(IProuductRespository respository):base(respository)
        {
            _repository = respository;

        }

    }
}
