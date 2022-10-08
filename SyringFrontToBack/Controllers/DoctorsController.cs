using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SyringFrontToBack.DAL;
using SyringFrontToBack.ViewModels;

namespace SyringFrontToBack.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public DoctorsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task< IActionResult> Index()
        {
            ViewBag.Title = "Find a Doctor";
            var doctorsinfocomponent = await _appDbContext.DoctorsInfoComponents.ToListAsync();

            var model = new DoctorsIndexViewModel
            {
                doctorsInfoComponents = doctorsinfocomponent
                
            };

            return View(model);
        }
    }
}
