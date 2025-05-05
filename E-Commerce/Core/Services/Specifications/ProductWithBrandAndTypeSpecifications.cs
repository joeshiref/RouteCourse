using Domain.Contracts;
using Domain.Entities;

namespace Services.Specifications
{
    internal class ProductWithBrandAndTypeSpecifications : Specifications<Product>
    {
        public ProductWithBrandAndTypeSpecifications(int id) : base(product => product.Id == id)
        {
            AddInclude(product => product.ProductBrand);
            AddInclude(product => product.ProductType);
        }

        public ProductWithBrandAndTypeSpecifications(string? sort, int? brandId, int? typeId) : 
            base(prod => 
            (!brandId.HasValue || prod.BrandId==brandId.Value) &&
            (!typeId.HasValue || prod.TypeId == typeId.Value)
            )
        {
            AddInclude(product => product.ProductBrand);
            AddInclude(product => product.ProductType);
            if(!string.IsNullOrWhiteSpace(sort))
            {
                switch(sort.ToLower().Trim())
                {
                    case "price":
                        SetOrderBy(product => product.Price);
                        break;
                    case "price_desc":
                        SetOrderByDesc(product => product.Price);
                        break;
                    default:
                        SetOrderBy(product => product.Name);
                        break;
                }
            }
        }
    }
}
