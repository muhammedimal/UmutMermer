using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using UmutMermer.BusinessLayer.Abstract;
using UmutMermer.BusinessLayer.Concrete;
using UmutMermer.DataAccesLayer.Abstract;
using UmutMermer.DataAccesLayer.Concrete;
using UmutMermer.DataAccesLayer.EntityFramework;
using UmutMermer.EntityLayer.Concrate;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

     
        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<Context>();
        builder.Services.AddHttpClient();
        builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
        builder.Services.AddScoped<IProductImageDal, EfProductImage>();
        builder.Services.AddScoped<IProductImageService, ProductImageManager>();
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