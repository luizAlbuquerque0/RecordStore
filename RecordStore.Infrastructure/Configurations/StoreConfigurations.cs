using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecordStore.Core.Entities;

namespace RecordStore.Infrastructure.Configurations
{
    public class StoreConfigurations : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder
                .HasKey(s => s.Id);
        }
    }
}
