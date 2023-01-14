using Domain.Data.Mappings;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Domain.Data;

public class DataContext : DbContext
{
    public DbSet<Vehicle> Vehicles { get; set; }
    //public DbSet<Supply> Supplies{ get; set; }


    protected override void OnModelCreating(ModelBuilder bilder)
    {
        bilder.ApplyConfiguration<Vehicle>(new VehicleConfiguration());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=127.0.0.1,1434;Database=control;User ID=sa;Password=123456;TrustServerCertificate=True");
        base.OnConfiguring(options);
    }
}