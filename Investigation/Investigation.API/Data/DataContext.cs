using Investigation.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Investigation.API.Data
{
    public class DataContext:DbContext


    {

        public DataContext(DbContextOptions<DataContext>options):base(options) { 
        
        
        
        
        
        
        }

        public DbSet<Project>Projects { get; set; }

        public DbSet<Investigator>Investigators { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

  
}
