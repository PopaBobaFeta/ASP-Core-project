using Events.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task = Events.Models.Task;

namespace Events.Data
{
    public class EventDbContext : DbContext
    {
        public EventDbContext(DbContextOptions<EventDbContext> options):base(options) { 
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(p => p.Company)
                .WithOne(b => b.User)
                .HasForeignKey<Company>(c => c.UserId);
        }

        public DbSet<Event> events { get; set; }
        public DbSet<User> users { get; set; }

        public DbSet<Company> companies { get; set; }

        public DbSet<Task> tasks { get; set; }
    }
}
