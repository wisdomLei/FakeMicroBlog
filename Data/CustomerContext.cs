using IPS.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPC.Data {
    class CustomerContext :DbContext{
        public CustomerContext(DbContextOptions<CustomerContext> options):base(options) {
            
        }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.ID);
        }
    }
}
