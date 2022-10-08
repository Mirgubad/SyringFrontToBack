using Microsoft.EntityFrameworkCore;
using SyringFrontToBack.Models;
using System.Reflection.PortableExecutable;

namespace SyringFrontToBack.DAL
{
    public class AppDbContext: DbContext
   
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet <DoctorsInfoComponent> DoctorsInfoComponents { get; set; }
        public DbSet<DepartmentServiceComponent> departmentServiceComponents { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SideBarProductsComponent> sideBarProductsComponents { get; set; }

    }
}
