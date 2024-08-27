using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext() : base() { }

        public DbSet<User> Users { get; set; }  
        public DbSet<UserRole> Roles { get; set; }

    }
}
