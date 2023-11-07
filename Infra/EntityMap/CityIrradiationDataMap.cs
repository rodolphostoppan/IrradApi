using IrradApi.Models.Request;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IrradApi.Infra.EntityMap;

public class CityIrradiationDataMap : IEntityTypeConfiguration<CityIrradiationData>
{
    public void Configure(EntityTypeBuilder<CityIrradiationData> builder)
    {
        builder.HasKey(property => property.Id);
        builder.Property(property => property.Id).ValueGeneratedOnAdd();
    }
}
