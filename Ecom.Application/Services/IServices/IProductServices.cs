using Ecom.Application.DTOs.Product;
using Ecom.Entities.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Application.Services.IServices
{
    public interface IProductServices
    {
        Task<ProductResponse> AddCartAsync(ProductRequest product);
    }
}
