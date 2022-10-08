using SyringFrontToBack.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));
var app = builder.Build();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=doctors}/{action=index}/{id?}");
app.UseStaticFiles();
app.Run();

