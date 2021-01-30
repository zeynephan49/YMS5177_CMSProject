using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using YMS5177_CMS.Data.Repositories.Interfaces.EntityTypeRepositories;
using YMS5177_CMS.Entity.Entities.Concrete;
using YMS5177_CMS.Entity.Enums;

namespace YMS5177_CMS.Web.Models.Components
{
    public class MainMenuViewComponent:ViewComponent
    {
        private readonly IPageRepository _pageRepo;

        public MainMenuViewComponent(IPageRepository pageRepository) => _pageRepo = pageRepository;
 
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pages = await GetPagesAsync();
            return View(pages);
        }

        private async Task<List<Page>> GetPagesAsync() => await _pageRepo.Get(x => x.Status != Status.Passive);
    }
}
