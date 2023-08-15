using UmutMermer.DataAccesLayer.Concrete;
using UmutMermer.EntityLayer.Concrate;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

     
        builder.Services.AddControllersWithViews();
        builder.Services.AddHttpClient();
        builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
        var app = builder.Build();
       

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.MapControllers();

        app.Run();
    }
}