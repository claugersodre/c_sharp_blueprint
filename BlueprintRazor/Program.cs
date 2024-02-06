using BlueprintRazor.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
string ConnectionString=builder.Configuration.GetConnectionString("DefaultConnection");
Console.WriteLine(ConnectionString);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataBaseContext>(options =>
{
    options.UseSqlServer(ConnectionString);

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
