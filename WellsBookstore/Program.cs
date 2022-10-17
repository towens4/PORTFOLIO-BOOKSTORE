var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();

app.MapControllerRoute("default", "{Controller=Home}/{Action=Index}/{id?}");



app.Run();
