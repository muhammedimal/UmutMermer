using AutoMapper;
using Microsoft.EntityFrameworkCore.Infrastructure;
using UmutMermer.DtoLAyer.Dtos.CategoryDto;
using UmutMermer.DtoLAyer.Dtos.CompanyInfoDto;
using UmutMermer.DtoLAyer.Dtos.LoginDto;
using UmutMermer.DtoLAyer.Dtos.ProductsDto;
using UmutMermer.DtoLAyer.Dtos.RegisterDto;
using UmutMermer.EntityLayer.Concrate;
using UmutMermer.WebUI.Dtos.CategoryDto;
using UmutMermer.WebUI.Models.AdminProduct;
using UmutMermer.WebUI.Models.CategoryDto;
using UmutMermer.WebUI.Models.ProductImage;
using UmutMermer.WebUI.Models.ProductVM;

namespace UmutMermer.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<GetCategoryDto, Category>().ReverseMap();
            CreateMap<UpdateCategoryDto, Category>().ReverseMap();
            CreateMap<AddCategoryDto, Category>().ReverseMap();
            CreateMap<ProductAddDto, Product>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();
            CreateMap<ProductGetDto, Product>().ReverseMap();
            CreateMap<AdminProductUpdateViewModel,Product>().ReverseMap();
            CreateMap<ResultProductVM, Product>().ReverseMap();
            CreateMap<CompanyInfoUpdateDto, CompanyInfo>().ReverseMap();
            CreateMap<CompanyInfoGetDto, CompanyInfo>().ReverseMap();
            CreateMap<AddUserDto, AppUser>().ReverseMap();
            CreateMap<LoginDto, AppUser>().ReverseMap();
            CreateMap<AddProductImageVM, ProductImage>().ReverseMap();
            CreateMap<ResultProductImageDto, ProductImage>().ReverseMap();
           
        }
    }
}
