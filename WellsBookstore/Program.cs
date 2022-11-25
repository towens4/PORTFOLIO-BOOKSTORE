
using Microsoft.EntityFrameworkCore;
using WellsBookstore.Models.DBContexts;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<WellsBookstoreDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DESKTOP-V1MK9K0\\SQLEXPRESS"));
});

builder.Services.AddMvc();

var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();

app.MapControllerRoute("default", "{Controller=Home}/{Action=Index}/{id?}");



app.Run();
