using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YMS5177_CMS.Data.Repositories.Interfaces.EntityTypeRepositories;

namespace YMS5177_CMS.Web.Models.Components
{
    public class CategoriesViewComponent:ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesViewComponent(ICategoryRepository categoryRepository) => _categoryRepository = categoryRepository;

        public async Task<IViewComponentResult> InvokeAsync() => View(await _categoryRepository.GetAll());

    }
}
