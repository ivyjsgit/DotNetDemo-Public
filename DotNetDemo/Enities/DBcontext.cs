using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetDemo.Enities
{
    public class DBcontext : DbContext
    {
        public DBcontext(DbContextOptions<DBcontext> options) : base(options)
        {
            //Database.EnsureCreated();
            Database.Migrate();
        }
    public DbSet<User> Users { get; set; }
    }
}
