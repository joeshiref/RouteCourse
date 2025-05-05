using AutoMapper;
using Domain.Contracts;
using Domain.Entities;
using Services.Abstraction;
using Services.Specifications;
using Shared.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService(IUnitOfWork unitOfWork, IMapper mapper): IProductService
    {

        public async Task<IEnumerable<ProductBrandResponse>> GetAllBrandsAsync()
        {
            var repo = unitOfWork.GetGenericRepo<ProductBrand, int>();
            var brands = await repo.GetAllAsync(false);
            var brandsResponse = mapper.Map<IEnumerable<ProductBrandResponse>>(brands);
            return brandsResponse;
        }

        public async Task<IEnumerable<ProductResponse>> GetAllProductsAsync(string? sort, int? brandId, int? typeId)
        {
            var repo = unitOfWork.GetGenericRepo<Product, int>();
            var products = await repo.GetAllAsync(new ProductWithBrandAndTypeSpecifications(sort,brandId,typeId));
            var productsResponse = mapper.Map<IEnumerable<ProductResponse>>(products);
            return productsResponse;
        }

        public async Task<IEnumerable<ProductTypeResponse>> GetAllTypesAsync()
        {
            var repo = unitOfWork.GetGenericRepo<ProductType, int>();
            var types = await repo.GetAllAsync(false);
            var typesResponse = mapper.Map<IEnumerable<ProductTypeResponse>>(types);
            return typesResponse;
        }

        public async Task<ProductResponse> GetProductByIdAsync(int id)
        {
            var repo = unitOfWork.GetGenericRepo<Product, int>();
            var product = await repo.GetByIdAsync(new ProductWithBrandAndTypeSpecifications(id)); 
            if (product == null) return null;
            var productResponse = mapper.Map<ProductResponse>(product);
            return productResponse;
        }
    }
}
