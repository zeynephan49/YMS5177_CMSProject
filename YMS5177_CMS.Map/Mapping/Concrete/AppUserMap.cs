using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YMS5177_CMS.Entity.Entities.Concrete;
using YMS5177_CMS.Map.Mapping.Abstract;

namespace YMS5177_CMS.Map.Mapping.Concrete
{
    public class AppUserMap:BaseMap<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Occupation).IsRequired(true);
            base.Configure(builder);
        }
    }
}
