using Shop_Management_System.Model;
using System.Data.Entity;


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
