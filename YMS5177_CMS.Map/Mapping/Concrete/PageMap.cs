using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YMS5177_CMS.Entity.Entities.Concrete;
using YMS5177_CMS.Map.Mapping.Abstract;

namespace YMS5177_CMS.Map.Mapping.Concrete
{
    public class PageMap:BaseMap<Page>
    {
        public override void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired(true);
            builder.Property(x => x.Slug).IsRequired(true);
            builder.Property(x => x.Sorting).IsRequired(true);
            builder.Property(x => x.Content).IsRequired(true);
            base.Configure(builder);
        }
    }
}
