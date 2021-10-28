using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManagementAPI.Entities;

namespace ProductManagementAPI.Repositories
{
    public class AttributeRepository : IAttributeRepository
    {
        public readonly ProductContext _context;
        public AttributeRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task CreateAttribute(ProductAttributes productAttributes)
        {
            _context.ProductAttributes.Add(productAttributes);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAttribute(Guid sku)
        {
            var itemToDelete = await _context.ProductAttributes.FindAsync(sku);
            if (itemToDelete is null)
                throw new NullReferenceException();

            _context.ProductAttributes.Remove(itemToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<ProductAttributes> GetAttribute(Guid id)
        {
            return await _context.ProductAttributes.FindAsync(id);
        }

        public async Task<IEnumerable<ProductAttributes>> GetAttributes()
        {
            return await _context.ProductAttributes.ToListAsync();
        }

        public async Task UpdateAttribute(ProductAttributes updatedProductAttributes)
        {
            var itemToUpdate = await _context.ProductAttributes.FindAsync(updatedProductAttributes.ProductSKU);
            if (itemToUpdate is null)
                throw new NullReferenceException();

            itemToUpdate.Name = updatedProductAttributes.Name;
            itemToUpdate.AttributeValues = updatedProductAttributes.AttributeValues;

            await _context.SaveChangesAsync();
        }
    }
}