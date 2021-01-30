using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YMS5177_CMS.Data.Repositories.Interfaces.EntityTypeRepositories;
using YMS5177_CMS.Entity.Entities.Concrete;

namespace YMS5177_CMS.Web.Controllers
{
    public class PageController : Controller
    {
        private readonly IPageRepository _pageRepository;

        public PageController(IPageRepository pageRepository) => _pageRepository = pageRepository;

        public async Task<IActionResult> Page(string slug) 
        {
            if (slug == null) return View(await _pageRepository.FirstOrDefault(x => x.Slug == "home-page"));

            Page page = await _pageRepository.FirstOrDefault(x => x.Slug == slug);

            if (page == null) return NotFound();

            return View(page);
        } 
    }
}
