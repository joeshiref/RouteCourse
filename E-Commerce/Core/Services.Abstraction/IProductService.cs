using Shared;
using Shared.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstraction
{
    public interface IProductService
    {
        // Get all products
        public Task<PaginatedResult<ProductResponse>> GetAllProductsAsync(ProductParametersSpecs specs);

        // Get Product by ID
        public Task<ProductResponse> GetProductByIdAsync(int id);
        // Get all brands
        public Task<IEnumerable<ProductBrandResponse>> GetAllBrandsAsync();
        // Get all types
        public Task<IEnumerable<ProductTypeResponse>> GetAllTypesAsync();
    }
}
