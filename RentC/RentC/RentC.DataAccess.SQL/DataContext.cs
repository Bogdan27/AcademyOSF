using RentC.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.DataAccess.SQL
{
    public class DataContext : DbContext
    {

        public DataContext() : base("rentConnectionString")
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
