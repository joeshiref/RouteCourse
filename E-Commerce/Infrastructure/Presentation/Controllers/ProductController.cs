using Microsoft.AspNetCore.Mvc;
using Services.Abstraction;
using Shared.DTOs.Product;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IServiceManager serviceManager) : ControllerBase
    {
        // Get all products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetAllProducts(string? sort, int? brandId, int? typeId)
        {
            var products = await serviceManager.ProductService.GetAllProductsAsync(sort,brandId,typeId);
            return Ok(products);
        }

        // Get Product by ID
        [HttpGet("{id:int}")]
        public async Task<ProductResponse> GetProductById(int id)
        {
            var product = await serviceManager.ProductService.GetProductByIdAsync(id);
            return (product);
        }

        // Get all brands
        [HttpGet("brands")]
        public async Task<ActionResult<IEnumerable<ProductBrandResponse>>> GetAllBrands()
        {
            var brands = await serviceManager.ProductService.GetAllBrandsAsync();
            return Ok(brands);
        }

        // Get all types
        [HttpGet("types")]
        public async Task<ActionResult<IEnumerable<ProductTypeResponse>>> GetAllTypes()
        {
            var types = await serviceManager.ProductService.GetAllTypesAsync();
            return Ok(types);
        }

    }
}
