using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using System.Collections.Generic;

namespace Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }
    }
}
