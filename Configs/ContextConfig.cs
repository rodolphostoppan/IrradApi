using IrradApi.Infra.EntityMap;
using IrradApi.Models.Request;
using Microsoft.EntityFrameworkCore;

namespace IrradApi.Configs
{
    public class ContextConfig : DbContext
    {
        public required DbSet<CityIrradiation> CityIrradiation { get; set; }

        public ContextConfig(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CityIrradiationMap());
            modelBuilder.ApplyConfiguration(new CityIrradiationDataMap());
        }
    }
}