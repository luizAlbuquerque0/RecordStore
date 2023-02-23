using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecordStore.Core.Entities;

namespace RecordStore.Infrastructure.Configurations
{
    public class RecordConfigurations : IEntityTypeConfiguration<Record>
    {
        public void Configure(EntityTypeBuilder<Record> builder)
        {
            builder
                .HasKey(r => r.Id);

            builder
                .HasOne(r => r.Store)
                .WithMany(s => s.Records)
                .HasForeignKey(r => r.StoreId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
