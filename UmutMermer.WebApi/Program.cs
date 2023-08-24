using UmutMermer.BusinessLayer.Abstract;
using UmutMermer.BusinessLayer.Concrete;
using UmutMermer.DataAccesLayer.Abstract;
using UmutMermer.DataAccesLayer.Concrete;
using UmutMermer.DataAccesLayer.EntityFramework;
using UmutMermer.EntityLayer.Concrate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IAppUserDal , EfAppUserDal>();
builder.Services.AddScoped<IAppUserService,AppUserManager>();
builder.Services.AddScoped<ICompanyInfoDal, EfCompanyInfo>();
builder.Services.AddScoped<ICompanyInfoService, CompanyInfoManager>();
//builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddScoped<IPortfolioDal, EfPortfolio>();
builder.Services.AddScoped<IPortfolioService, PortfolioManager>();
builder.Services.AddScoped<IProductImageDal , EfProductImage>();
builder.Services.AddScoped<IProductImageService , ProductImageManager>();
builder.Services.AddScoped<IProductsDal, EfProducts>();
builder.Services.AddScoped<IProductsService, ProductsManager>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);










builder.Services.AddCors(opt =>
{
    opt.AddPolicy("MermerApiCors", opts =>
    {
        opts.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    });


});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("MermerApiCors");
app.UseAuthorization();

app.UseStaticFiles();
app.MapControllers();

app.Run();
