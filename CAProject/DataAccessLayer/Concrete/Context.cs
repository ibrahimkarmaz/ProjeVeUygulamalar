using EntityLayer.Concrete;
using EntityLayer.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMAP());
            modelBuilder.Configurations.Add(new CompanyMAP());
            modelBuilder.Configurations.Add(new CustomerMAP());
        }
    }
}
