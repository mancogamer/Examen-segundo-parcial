using exam.Models;
using Microsoft.EntityFrameworkCore;

namespace exam.Context
{
    public class App_context : DbContext
    {
        public App_context
            (DbContextOptions<App_context> options)
            : base(options) { }

        public DbSet<Musica> musica { 
            get; set; 
        }
        public DbSet<Disco> disco { 
            get; set;
        }


    }
}
