
using YMS5177_CMS.Data.Context;
using YMS5177_CMS.Data.Repositories.Concrete.Base;
using YMS5177_CMS.Data.Repositories.Interfaces.EntityTypeRepositories;
using YMS5177_CMS.Entity.Entities.Concrete;

namespace YMS5177_CMS.Data.Repositories.Concrete.EntityTypeRepositories
{
    public class AppUserRepository: KernelRepository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext){}
    }
}
