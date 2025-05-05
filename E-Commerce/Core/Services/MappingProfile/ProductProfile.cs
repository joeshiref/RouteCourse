using AutoMapper;
using Domain.Entities;
using Shared.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.MappingProfile
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductResponse>().
                ForMember(dest => dest.BrandName, options =>
                options.MapFrom(src => src.ProductBrand.Name)).
                ForMember(dest => dest.TypeName, options =>
                options.MapFrom(src => src.ProductType.Name)).
                ForMember(dest => dest.PictureUrl, options =>
                options.MapFrom<PictureUrlResolver>());

            CreateMap<ProductBrand, ProductBrandResponse>().
                ForMember(dest => dest.Id, options =>
                options.MapFrom(src => src.Id)).
                ForMember(dest => dest.Name, options =>
                options.MapFrom(src => src.Name));
        }
    }
}
