using AutoMapper;
using Domain.Contracts;
using Domain.Entities;
using Services.Abstraction;
using Services.Specifications;
using Shared;
using Shared.DTOs.Product;

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
         
        public async Task<PaginatedResult<ProductResponse>> GetAllProductsAsync(ProductParametersSpecs specs)
        {
            var products = await unitOfWork.GetGenericRepo<Product, int>().GetAllAsync(new ProductWithBrandAndTypeSpecifications(specs));
            var totalCount = await unitOfWork.GetGenericRepo<Product, int>().CountAsync(new ProductCountSpecs(specs));
            var productsResponse = mapper.Map<IEnumerable<ProductResponse>>(products);
            //return productsResponse;
            var result = new PaginatedResult<ProductResponse>(
                specs.pageIndex, 
                specs.PageSize,
                totalCount, 
                productsResponse
                );
            return result;
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
