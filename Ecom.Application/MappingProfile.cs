using AutoMapper;
using Ecom.Application.DTOs.Product;
using Ecom.Entities.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductRequest, Product>();
            CreateMap<Product, ProductResponse>();
            
        }
    }
}
