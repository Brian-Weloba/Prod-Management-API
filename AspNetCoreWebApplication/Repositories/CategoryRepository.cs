using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManagementAPI.Entities;

namespace ProductManagementAPI.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly ProductContext _context;
        public CategoryRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task CreateProductCategory(ProductCategory productCategory)
        {
            _context.ProductCategory.Add(productCategory);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductCategory(Guid id)
        {
             var itemToDelete = await _context.ProductCategory.FindAsync(id);
            if (itemToDelete is null)
                throw new NullReferenceException();

            _context.ProductCategory.Remove(itemToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductCategory>> getProductCategories()
        {
            return await _context.ProductCategory.ToListAsync();
        }

        public async Task<ProductCategory> GetProductCategory(Guid id)
        {
            return await _context.ProductCategory.FindAsync(id);
        }

        public async Task UpdateProductCategory(ProductCategory updatedProductCategory)
        {
             var itemToUpdate = await _context.ProductCategory.FindAsync(updatedProductCategory.Id);
            if (itemToUpdate is null)
                throw new NullReferenceException();

            itemToUpdate.Name = updatedProductCategory.Name;
            itemToUpdate.Description = updatedProductCategory.Description;
        }
    }

}