using Ecom.DataAccess.Persistence;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Entities.Entities.Product;

namespace Ecom.DataAccess.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
