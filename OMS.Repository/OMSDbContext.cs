using Microsoft.EntityFrameworkCore;
using OMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Repository
{
    public class OMSDbContext : DbContext
    {
        public OMSDbContext(DbContextOptions<OMSDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
