using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProductManagementAPI.Entities;

namespace ProductManagementAPI.Repositories
{
    public interface IAttributeRepository
    {
        Task<ProductAttributes> GetAttribute(Guid id);
        Task<IEnumerable<ProductAttributes>> GetAttributes();
        Task CreateAttribute(ProductAttributes productAttributes);
        Task UpdateAttribute(ProductAttributes updatedProductAttributes);
        Task DeleteAttribute(Guid sku);
    }
}