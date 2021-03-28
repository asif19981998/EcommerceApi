
using Ecommerce.DataBaseContext;
using Ecommerce.Models.EntityModels;
using Ecommerce.Repositories.Abstractions.EntityContracts;
using Ecommerce.Repositories.Base;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repositories
{
    public class ProductRepository:BaseRepository<Product>,IProuductRespository
    {
        private EcommerceDbContext _db;
        public ProductRepository(DbContext db):base(db)
        {
            _db = (EcommerceDbContext)db;
        }
    }
}
