using Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Data.Mappings;

public class SupplyConfiguration : IEntityTypeConfiguration<Supply>
{
	public void Configure(EntityTypeBuilder<Supply> builder)
	{
		builder.ToTable<Supply>("SUPPLY");
		builder.HasKey(x => x.Id);
		
		builder.Property(supply => supply.Id)
			.HasColumnName("ID");
		
		builder.Property(supply => supply.VehicleId)
			.HasColumnName("VEHICLEID");
			
		builder.Property(supply => supply.Km)
			.HasColumnName("KM")
			.HasColumnType("FLOAT");
			
		builder.Property(supply => supply.Quantity)
			.HasColumnName("QUANTITY")
			.HasColumnType("FLOAT");;
			
		builder.Property(supply => supply.Date)
			.HasColumnName("DATE_SUPPLY")
			.HasColumnType("DATETIME");
		
		builder.Property(supply => supply.Value)
			.HasColumnName("VALUE_SUPPLY")
			.HasColumnType("FLOAT");
		
		builder.HasOne(supply => supply.Vehicle);
		
		// builder.Ignore(supply => supply.Vehicle);
	}
}
