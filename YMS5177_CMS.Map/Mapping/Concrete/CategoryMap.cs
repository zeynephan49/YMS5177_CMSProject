using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YMS5177_CMS.Entity.Entities.Concrete;
using YMS5177_CMS.Map.Mapping.Abstract;

namespace YMS5177_CMS.Map.Mapping.Concrete
{
    public class CategoryMap:BaseMap<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(true);
            base.Configure(builder);
        }
    }
}
