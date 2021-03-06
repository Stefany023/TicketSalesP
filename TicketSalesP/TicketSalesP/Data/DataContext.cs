using Microsoft.EntityFrameworkCore;
using TicketSalesP.Data.Entities;

namespace TicketSalesP.Data
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Entrance> Entrances { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entrance>().HasIndex(e => e.Description).IsUnique();
            //modelBuilder.Entity<Ticket>().HasIndex(t => t.Id).IsUnique();
        }
    }

}

