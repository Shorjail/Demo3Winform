using Demo3WinForm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3WinForm.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext() : base("name=DefaultConnection")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProcessRoute> Routes { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<ProcessParameters> ProcessParameters { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
           .HasOptional(p => p.Route)
           .WithRequired(r => r.Product);

            modelBuilder.Entity<ProcessRoute>()
                .HasMany(r => r.Processes)
                .WithRequired(p => p.Route)
                .HasForeignKey(p => p.RouteId);

            modelBuilder.Entity<Process>()
                .HasMany(p => p.ProcessParameters)
                .WithRequired(pp => pp.Process)
                .HasForeignKey(pp => pp.ProcessId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
