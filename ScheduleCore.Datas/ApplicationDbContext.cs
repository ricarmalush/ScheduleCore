using Microsoft.EntityFrameworkCore;
using ScheduleCore.Entities.Models;

namespace ScheduleCore.Datas
{
    public class ApplicationDbContext : DbContext
    {
        //
        public DbSet<Country> Country { get; set; }
        public DbSet<Province> Province { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public ApplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

    }
}