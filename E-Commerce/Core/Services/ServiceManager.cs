using AutoMapper;
using Domain.Contracts;
using Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager(IUnitOfWork unitOfWork, IMapper mapper) : IServiceManager
    {
        private readonly Lazy<IProductService> _lazyProductService = 
            new Lazy<IProductService>(new ProductService(unitOfWork,mapper));
        public IProductService ProductService => _lazyProductService.Value;
    }

}
