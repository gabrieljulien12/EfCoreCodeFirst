using EfCoreCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreCodeFirst.Models.Configuration
{
    public class AppUserConfiguration:BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Profile).WithOne(x => x.AppUser).HasForeignKey<AppUser>(x => x.ID);
        }
    }
}
