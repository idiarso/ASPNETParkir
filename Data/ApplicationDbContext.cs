using Microsoft.EntityFrameworkCore;
using ParkingManagementSystem.Models;

namespace ParkingManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<ParkingSpace> ParkingSpaces { get; set; }
        public DbSet<ParkingTicket> ParkingTickets { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ParkingSpace>()
                .HasOne(p => p.CurrentVehicle)
                .WithMany()
                .HasForeignKey(p => p.CurrentVehicleId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ParkingTicket>()
                .HasOne(t => t.Vehicle)
                .WithMany()
                .HasForeignKey(t => t.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ParkingTicket>()
                .HasOne(t => t.ParkingSpace)
                .WithMany()
                .HasForeignKey(t => t.ParkingSpaceId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed admin user
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin123"),
                    FirstName = "System",
                    LastName = "Administrator",
                    Email = "admin@parking.com",
                    Role = "Admin",
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                }
            );
        }
    }
}