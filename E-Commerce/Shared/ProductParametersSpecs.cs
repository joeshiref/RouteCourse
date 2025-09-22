using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ProductParametersSpecs
    {
        public int? typeId { get; set; }
        public int? brandId { get; set; }
        public SortOptions? sort { get; set; }
        public int pageIndex { get; set; } = 1;
        private const int maxPageSize = 10;
        private const int defaultPageSize = 5;

        private int _pageSize = defaultPageSize;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value > maxPageSize ? maxPageSize : value;
        }


    }
    public enum SortOptions
    {
        Price,
        PriceDesc,
        Name
    }
}
