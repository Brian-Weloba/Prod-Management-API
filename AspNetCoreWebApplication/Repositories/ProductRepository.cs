using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManagementAPI.Entities;

namespace ProductManagementAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public readonly ProductContext _context;
        public ProductRepository(ProductContext context)
        {
            _context = context;
        }
        public async Task CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(Guid sku)
        {
            var itemToDelete = await _context.Products.FindAsync(sku);
            if (itemToDelete is null)
                throw new NullReferenceException();

            _context.Products.Remove(itemToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetProduct(Guid sku)
        {
            return await _context.Products.FindAsync(sku);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        // public async Task UpdateAttributes(Product updatedProduct)
        // {
        //     var itemToUpdate = await _context.Products.FindAsync(updatedProduct.SKU);
        //     if (itemToUpdate is null)
        //         throw new NullReferenceException();

        //     itemToUpdate.Attributes = updatedProduct.Attributes;

        //     await _context.SaveChangesAsync();
            
        // }

        public async Task UpdateProduct(Product updatedProduct)
        {
            var itemToUpdate = await _context.Products.FindAsync(updatedProduct.SKU);
            if (itemToUpdate is null)
                throw new NullReferenceException();

            if (itemToUpdate.Name != null)
            {
                itemToUpdate.Name = updatedProduct.Name;
            }
            if (itemToUpdate.Brand != null)
            {
                itemToUpdate.Brand = updatedProduct.Brand;
            }
            if (itemToUpdate.Price != 0)
            {
                itemToUpdate.Price = updatedProduct.Price;
            }
            if (itemToUpdate.Quantity != 0)
            
            {
                itemToUpdate.Quantity = updatedProduct.Quantity;
            }

            await _context.SaveChangesAsync();
        }
    }
}