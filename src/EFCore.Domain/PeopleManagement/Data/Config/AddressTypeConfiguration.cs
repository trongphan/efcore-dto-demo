using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Domain.PeopleManagement.Data.Config;

public class AddressTypeConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Addresses");

        builder.Property<int>("Id");
        builder.Property<string>("Type");

        builder.HasDiscriminator<string>("Type")
                .HasValue<DeliveryAddress>(nameof(DeliveryAddress))
                .HasValue<InvoiceAddress>(nameof(InvoiceAddress));

        builder.HasKey("Id");
    }
}
