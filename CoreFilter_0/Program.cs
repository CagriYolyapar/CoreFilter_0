var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    name: "default",
    //Controller ve Action'in bulundugu kesim baz kesimdir... Bunun dısında kalan yapılar RouteData'dir...Mesela asagıdaki pattern'de id RouteDate'ya girer (Url'den Server'a istek yapıldıgı zaman karsılanacak istegin icerisinde bulunan baz adres dısındaki tüm bilgiler...
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
