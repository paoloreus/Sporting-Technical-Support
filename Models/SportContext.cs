using Microsoft.EntityFrameworkCore;

namespace Assig1ProtoType.Models
{
    public class SportContext : DbContext
    {
        public SportContext(DbContextOptions<SportContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<Incident> Incidents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    Name = "Jim"
                },
                new Customer
                {
                    CustomerId = 2,
                    Name = "Max"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Visual Studio Pro"
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Google Colab Pro"
                });

            modelBuilder.Entity<Technician>().HasData(
                new Technician
                {
                    TechnicianId = 1,
                    Name = "Mondi"
                },
                new Technician
                {
                    TechnicianId = 2,
                    Name = "Robbi"
                }
                );

            modelBuilder.Entity<Incident>().HasData(
                new Incident
                {
                    IncidentId = 1,
                    Title = "Key Not Working",
                    CustomerId = 1,
                    ProductId = 1,
                    TechnicianId = 1
                },
                new Incident
                {
                    IncidentId = 2,
                    Title = "IntelliSense not so intelligent",
                    CustomerId = 2,
                    ProductId = 2,
                    TechnicianId = 2
                }
                );
        }
    }
}
