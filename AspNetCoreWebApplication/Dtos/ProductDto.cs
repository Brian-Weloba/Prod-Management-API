using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProductManagementAPI.Entities;

namespace ProductManagementAPI.Dtos
{
    public record ProductDto
    {

        private Random random = new Random();
        public string Name { get; init; }
        public string Brand { get; init; }
        public decimal Price { get; init; }
        public int Quantity { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
        [Key]
        public Guid SKU { get; init; }
        public List<ProductAttributes> Attributes { get; init; }

        // public ProductDto(string vendor, string name, string brand, decimal price, int quantity, DateTimeOffset createdDate, Dictionary<string, string> attributes)
        // {
        //     Vendor = vendor;
        //     Name = name;
        //     Brand = brand;
        //     Price = price;
        //     Quantity = quantity;
        //     CreatedDate = createdDate;
        //     SKU = Guid.NewGuid();
        //     Attributes = attributes;
        // }

        // public ProductDto(string vendor, string name, decimal price, int quantity, DateTimeOffset createdDate)
        // {
        //     Vendor = vendor;
        //     Name = name;
        //     Price = price;
        //     Quantity = quantity;
        //     CreatedDate = createdDate;
        //     SKU = Guid.NewGuid();
        //     Attributes = null;
        // }

        public ProductDto()
        {
            SKU = Guid.NewGuid();
        }
    }
}