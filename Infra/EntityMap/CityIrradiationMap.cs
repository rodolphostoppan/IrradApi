using IrradApi.Models.Request;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IrradApi.Infra.EntityMap;

public class CityIrradiationMap : IEntityTypeConfiguration<CityIrradiation>
{
    public void Configure(EntityTypeBuilder<CityIrradiation> builder)
    {
        builder.HasKey(property => property.NameIdentification);
    }
}