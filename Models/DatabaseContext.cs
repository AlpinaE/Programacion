using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace programcion.models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        
        public DbSet<Student> Students { get; set; }

    }
}