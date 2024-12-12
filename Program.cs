using Microsoft.EntityFrameworkCore;
using WebApplication7.Services;
using WebApplication9.DataFolder;
using WebApplication9.Services;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("DefaultConnection");    
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connString));



// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddCVServices();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
