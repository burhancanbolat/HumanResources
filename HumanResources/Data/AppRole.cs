using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HumanResources.Data
{
    public class AppRole : IdentityRole<Guid>
    {
    }
    public class AppRoleEntityTypeConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder
                 .Property(x => x.Name)
                 .HasMaxLength(191);
            builder
                .Property(x=>x.NormalizedName)
                .HasMaxLength (191);

        }
    }
}
