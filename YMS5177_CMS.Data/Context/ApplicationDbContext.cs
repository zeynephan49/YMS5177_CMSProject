using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YMS5177_CMS.Data.SeedData;
using YMS5177_CMS.Entity.Entities.Concrete;
using YMS5177_CMS.Entity.Entities.Interfaces;
using YMS5177_CMS.Map.Mapping.Concrete;

namespace YMS5177_CMS.Data.Context
{
    public class ApplicationDbContext: IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}

        public DbSet<Category> Categories { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new AppUserMap());
            builder.ApplyConfiguration(new PageMap());
            builder.ApplyConfiguration(new ProductMap());

            //builder.Entity<Product>().Property(x => x.UnitPrice).HasColumnType("decimal");
            //Hatırlarsanız Standart .Net'te projedeki datetime tipine sahip varlıkları burada toptan map etmiştim. Bu projede datetime tipine sahip property'leri IBaseEntity.cs arayüzünde tutuğumuzda burada ben map edememiştim vakti zamanında sizde uğraşın.
            //builder.Entity<IBaseEntity>().Property(x => x.CreateDate).HasColumnType("datetime2");
            builder.ApplyConfiguration(new SeedPages());

            base.OnModelCreating(builder);
        }
    }
}
