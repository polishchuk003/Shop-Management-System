using Shop_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Xml.Linq;


namespace Shop_Management_System.DBContext
{
    public class DataDbContext : DbContext
    {
        public DataDbContext() : base("name=DataDbContext")
        {
        }

        public DbSet<ItemModel> Items { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<BillModel> Bills { get; set; }


    }
}
