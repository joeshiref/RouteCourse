namespace Persistance.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(x => x.ProductBrand)
                .WithMany()
                .HasForeignKey(x => x.BrandId);

            builder.HasOne(x => x.ProductType)
                .WithMany()
                .HasForeignKey(x => x.TypeId);

            builder.Property(x => x.Price).HasColumnType("decimal(18,3)");
        }
    }
}