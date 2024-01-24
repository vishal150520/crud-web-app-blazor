using BlazorAppCRUD.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Xml.Serialization;

namespace BlazorAppCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Orders> order { get; set; }
        public DbSet<SubElements> subelement { get; set; }
        public DbSet<Windows> window { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Orders>()
            //    .HasMany(o => o.Windows);
            //modelBuilder.Entity<Windows>()
            //    .HasMany(o => o.SubElements);
        }
    };
}
