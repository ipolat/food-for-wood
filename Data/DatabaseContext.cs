

using Microsoft.EntityFrameworkCore;

namespace deneme4.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext() 
        { 
        }
        public DbSet<Person> Person { get; set; }
        public DatabaseContext( DbContextOptions<DatabaseContext> options) 
            : base(options) 
        {
        
        }

    }
}
