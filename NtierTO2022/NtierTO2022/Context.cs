using NtierTO2022.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierTO2022
{
    public class Context:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
