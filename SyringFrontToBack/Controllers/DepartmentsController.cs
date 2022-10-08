using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SyringFrontToBack.DAL;
using SyringFrontToBack.ViewModels;

namespace SyringFrontToBack.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentsController(AppDbContext appDbContext)

        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var departmentServiceComponents = await _appDbContext.departmentServiceComponents.ToListAsync();
            ViewBag.Title = "Medical Department";
            var model = new DepartmentIndexViewModel
            {
                departmentServiceComponents = departmentServiceComponents,

            };

            return View(model);
        }
    }
}
