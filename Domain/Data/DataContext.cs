using Domain.Data.Mappings;
using Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Domain.Data;

public class DataContext : DbContext
{
	public DbSet<Vehicle> Vehicles { get; set; }
	public DbSet<Supply> Supplies{ get; set; }

	protected override void OnModelCreating(ModelBuilder bilder)
	{
		bilder.ApplyConfiguration<Vehicle>(new VehicleConfiguration());
		bilder.ApplyConfiguration<Supply>(new SupplyConfiguration());
	}

	protected override void OnConfiguring(DbContextOptionsBuilder options)
	{
		options.UseSqlServer("Server=127.0.0.1,1434;Database=control;User ID=sa;Password=123456;TrustServerCertificate=True");
		base.OnConfiguring(options);
	}
}