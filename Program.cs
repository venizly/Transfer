using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectFinal1.Areas.Identity.Data;
using ProjectFinal1.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ProjectDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ProjectDbContextConnection' not found.");

builder.Services.AddDbContext<ProjectDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<AppilcationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ProjectDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireUppercase = false;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "LoginUser",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();


app.Run();
