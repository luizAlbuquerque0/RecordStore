using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecordStore.Core.Entities;

namespace RecordStore.Infrastructure.Configurations
{
    public class OrderConfigurations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                 .HasKey(o => o.Id);

            builder
                .HasOne(o => o.User)
                .WithMany(u => u.UserOrders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(o => o.Store)
                .WithMany(s => s.StoreOrders)
                .HasForeignKey(o => o.StoreId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(o => o.Cart)
                .WithOne(c => c.Order)
                .HasForeignKey<Order>(o => o.Cart.Id);

        }
    }
}
