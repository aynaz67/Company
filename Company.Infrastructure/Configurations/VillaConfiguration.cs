using Company.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company.Infrastructure.Configurations
{
    public class VillaConfiguration : IEntityTypeConfiguration<Villa>
    {
        public void Configure(EntityTypeBuilder<Villa> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(s => s.CreateDate)
                  .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(s => s.UpdateDate)
                  .HasDefaultValueSql("GETUTCDATE()");

        }
    }
}
