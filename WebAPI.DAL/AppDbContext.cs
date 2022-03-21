using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.DAL
{
    public partial class AppDbContext : DbContext
    {
    
        public DbSet<Account> Accounts { get; set; }
        public DbSet<FileImage> FileImages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestProducts> RequestProducts { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<Authentication> Authentication { get; set; }
        public DbSet<Authorization> Authorization { get; set; }

        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string @connectionString = "Data Source=DESKTOP-5UN1UVJ;Initial Catalog=WebAPI;Integrated Security=True;Pooling=False";
                optionsBuilder.UseSqlServer(@connectionString);
            }
            
        }

    }
}
