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
        Task<IEnumerable<ProductResponse>> GetAllProductsAsync(string? sort, int? brandId, int? typeId);

        // Get Product by ID
        Task<ProductResponse> GetProductByIdAsync(int id);
        // Get all brands
        Task<IEnumerable<ProductBrandResponse>> GetAllBrandsAsync();
        // Get all types
        Task<IEnumerable<ProductTypeResponse>> GetAllTypesAsync();
    }
}
