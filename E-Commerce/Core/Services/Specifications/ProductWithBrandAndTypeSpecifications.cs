using Domain.Contracts;
using Domain.Entities;
using Shared;

namespace Services.Specifications
{
    internal class ProductWithBrandAndTypeSpecifications : Specifications<Product>
    {
        public ProductWithBrandAndTypeSpecifications(int id) : base(product => product.Id == id)
        {
            AddInclude(product => product.ProductBrand);
            AddInclude(product => product.ProductType);
        }

        public ProductWithBrandAndTypeSpecifications(ProductParametersSpecs specs) : 
            base(prod => 
            (!specs.brandId.HasValue || prod.BrandId== specs.brandId.Value) &&
            (!specs.typeId.HasValue || prod.TypeId == specs.typeId.Value)
            )
        {
            AddInclude(product => product.ProductBrand);
            AddInclude(product => product.ProductType);
            if(specs.sort is not null)
            {
                switch(specs.sort)
                {
                    case SortOptions.Price:
                        SetOrderBy(product => product.Price);
                        break;
                    case SortOptions.PriceDesc:
                        SetOrderByDesc(product => product.Price);
                        break;
                    default:
                        SetOrderBy(product => product.Name);
                        break;
                }
            }
            ApplyPagination(specs.pageIndex, specs.PageSize);
        }
    }
}
