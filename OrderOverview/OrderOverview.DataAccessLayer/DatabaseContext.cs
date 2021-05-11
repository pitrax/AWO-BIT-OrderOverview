using OrderOverview.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OrderOverview.DataAccessLayer
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<GeneralProcesses> GeneralProcesses { get; set; }
        public DbSet<ProductProcesses> ProductProcesses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<User>Users{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
}
