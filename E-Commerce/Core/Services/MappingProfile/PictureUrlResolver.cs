using AutoMapper;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using Shared.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.MappingProfile
{
    public class PictureUrlResolver(IConfiguration configuration) :IValueResolver<Product, ProductResponse, string>
    {
        public string Resolve(Product source, ProductResponse destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return $"{configuration["BaseUrl"]}{source.PictureUrl}";
            }
            return null;
        }
    }
}
