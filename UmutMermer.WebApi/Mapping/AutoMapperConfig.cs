using AutoMapper;
using Microsoft.EntityFrameworkCore.Infrastructure;
using UmutMermer.DtoLAyer.Dtos.CategoryDto;
using UmutMermer.DtoLAyer.Dtos.CompanyInfoDto;
using UmutMermer.DtoLAyer.Dtos.ProductImageDto;
using UmutMermer.DtoLAyer.Dtos.ProductsDto;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ProductAddDto, Product>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();
            CreateMap<ProductGetDto, Product>().ReverseMap();
            CreateMap<CompanyInfoUpdateDto, CompanyInfo>().ReverseMap();
            CreateMap<CompanyInfoGetDto, CompanyInfo>().ReverseMap();
            CreateMap<CategoryGetDto, Category>().ReverseMap();
            CreateMap<AddProductImage, ProductImage>().ReverseMap();
        }
    }
}
