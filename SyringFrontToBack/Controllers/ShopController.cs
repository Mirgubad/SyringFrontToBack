using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SyringFrontToBack.DAL;
using SyringFrontToBack.ViewModels;

namespace SyringFrontToBack.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ShopController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult>  Index()
        {
        
            var categories = await _appDbContext.Categories.Include(c => c.sideBarProductsCategories).ToListAsync();

            var model = new SideBarIndexViewModel
            {

                Categories=categories,

            };
            return View(model);
        }
    }
}
