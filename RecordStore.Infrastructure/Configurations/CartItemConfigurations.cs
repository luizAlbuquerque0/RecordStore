using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecordStore.Core.Entities;

namespace RecordStore.Infrastructure.Configurations
{
    public class CartItemConfigurations : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder
                .HasKey(ci => ci.Id);

            builder
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItem)
                .HasForeignKey(ci => ci.CartId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasOne(ci => ci.Record)
                .WithMany(r => r.CartItens)
                .HasForeignKey(ci => ci.RecordId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
