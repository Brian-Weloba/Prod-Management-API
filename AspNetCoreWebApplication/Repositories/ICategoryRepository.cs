using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProductManagementAPI.Entities;

namespace ProductManagementAPI.Repositories{
    public interface ICategoryRepository
    {
        Task CreateProductCategory(ProductCategory productCategory);
        Task DeleteProductCategory(Guid id);
        Task<IEnumerable<ProductCategory>> getProductCategories();
        Task<ProductCategory> GetProductCategory(Guid id);
        Task UpdateProductCategory(ProductCategory updatedProductCategory);
    }
}