using AutoMapper;
using Microsoft.EntityFrameworkCore.Infrastructure;
using UmutMermer.DtoLAyer.Dtos.CategoryDto;
using UmutMermer.DtoLAyer.Dtos.CompanyInfoDto;
using UmutMermer.DtoLAyer.Dtos.ProductsDto;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ProductAddDto, Products>().ReverseMap();
            CreateMap<ProductUpdateDto, Products>().ReverseMap();
            CreateMap<ProductGetDto, Products>().ReverseMap();
            CreateMap<CompanyInfoUpdateDto, CompanyInfo>().ReverseMap();
            CreateMap<CompanyInfoGetDto, CompanyInfo>().ReverseMap();
            CreateMap<CategoryGetDto, Category>().ReverseMap();
        }
    }
}
