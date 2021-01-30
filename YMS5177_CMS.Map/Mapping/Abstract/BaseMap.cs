using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YMS5177_CMS.Entity.Entities.Interfaces;

namespace YMS5177_CMS.Map.Mapping.Abstract
{
    public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T : class, IBaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x=> x.CreateDate).IsRequired(true);
            builder.Property(x=> x.UpdateDate).IsRequired(false);
            builder.Property(x=> x.DeleteDate).IsRequired(false);
            builder.Property(x => x.Status).IsRequired(false);
        }
    }
}
