using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repository;
using Rozklad.Repository.Repositories;
using System.Text.Json.Serialization;


//using RozkladSchool.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("RozkladSchoolConnection");
builder.Services.AddDbContext<RozkladContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();


builder.Services.AddDefaultIdentity<User>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 5;
}).AddRoles<IdentityRole>()
.AddEntityFrameworkStores<RozkladContext>();


builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<UsersRepository>();
builder.Services.AddTransient<ClassRepository>();
builder.Services.AddTransient<CabinetRepository>();
builder.Services.AddTransient<TeacherRepository>();
builder.Services.AddTransient<DisciplineRepository>();
builder.Services.AddTransient<PupilRepository>();
builder.Services.AddTransient<SectionRepository>();
builder.Services.AddTransient<TimetableRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
