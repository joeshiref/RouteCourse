using Domain.Contracts;
using Domain.Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Specifications
{
    public class ProductCountSpecs : Specifications<Product>
    {

        public ProductCountSpecs(ProductParametersSpecs specs) :
            base(prod =>
            (!specs.brandId.HasValue || prod.BrandId == specs.brandId.Value) &&
            (!specs.typeId.HasValue || prod.TypeId == specs.typeId.Value)
            )
        {

            
        }
    }
}
