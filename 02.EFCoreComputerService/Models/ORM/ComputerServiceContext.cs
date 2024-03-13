using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EFCoreComputerService.Models.ORM
{
    public class ComputerServiceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-2K18C6FK\SQLEXPRESS01;Database=ComputerServiceDb;trusted_connection=true;TrustServerCertificate=true");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SparePart> SpareParts { get; set; }
        public DbSet<ServiceStatus> ServiceStatuses { get; set; }
        public DbSet<ServiceRecord> ServiceRecords { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Staff> Staffs { get; set;}

    }
}
