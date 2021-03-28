using Ecommerce.Models;
using Ecommerce.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataBaseContext
{
    public class EcommerceDbContext:DbContext
    {
        public EcommerceDbContext(DbContextOptions options):base(options)
        {

        }
        DbSet<Product> Products { get; set; }
        DbSet<Shop> Shops { get; set; }
        DbSet<Customer> Customers { get; set; }
    }
}
