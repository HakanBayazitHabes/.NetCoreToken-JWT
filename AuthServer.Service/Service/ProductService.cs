using AuthServer.Core.DTOs;
using AuthServer.Core.Models;
using AuthServer.Core.Repositories;
using AuthServer.Core.Services;
using AuthServer.Core.UnitOfWork;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Service.Service
{
    public class ProductService : ServiceGeneric<Product, ProductDto>, IProductService
    {
        private readonly IProductRepository _productRepository;
        public readonly IMapper _mapper;
        public ProductService(IUnitofWork unitofWork, IGenericRepository<Product> repository, IProductRepository productRepository, IMapper mapper) : base(unitofWork, repository)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

    }
}
