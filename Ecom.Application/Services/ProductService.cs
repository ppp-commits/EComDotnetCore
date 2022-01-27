using AutoMapper;
using Ecom.Application.DTOs.Product;
using Ecom.Application.Services.IServices;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Entities.Entities.Product;
using System.Threading.Tasks;

namespace Ecom.Application.Services
{
    public class ProductService : IProductServices
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<ProductResponse> AddCartAsync(ProductRequest product)
        {
            var productEntity = _mapper.Map<Product>(product);
            var entityAdded = await _productRepository.AddAsync(productEntity);
            return _mapper.Map<ProductResponse>(entityAdded);
        }
    }
}
