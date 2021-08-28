using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
