using Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Data.Mappings;

public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.ToTable<Vehicle>("vehicle");
        builder.HasKey(x => x.Id);

        builder.Property(vehicle => vehicle.Id)
            .HasColumnName("ID")
            .HasColumnType("INT")
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
        
        builder.Property(vehicle => vehicle.Plate)
            .HasColumnName("PLATE")
            .HasColumnType("VARCHAR")
            .HasMaxLength(7);

        builder.Property(vehicle => vehicle.IncialKm)
            .HasColumnName("INCIALKM")
            .HasColumnType("FLOAT");

        builder.Property(vehicle => vehicle.ActuallKm)
            .HasColumnName("ACTUALKM")
            .HasColumnType("FLOAT");
    }
}
