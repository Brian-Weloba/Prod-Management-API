using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductManagementAPI.Entities
{
    public record Product
    {

        private Random random = new Random();
        // public string Vendor { get; init; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
        [Key]
        public Guid SKU { get; set; }
        public List<ProductAttributes> Attributes { get; set; }

        // public Product(string vendor, string name, string brand, decimal price, int quantity, DateTimeOffset createdDate, Dictionary<string, string> attributes)
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

        // public Product(string vendor, string name, decimal price, int quantity, DateTimeOffset createdDate)
        // {
        //     Vendor = vendor;
        //     Name = name;
        //     Price = price;
        //     Quantity = quantity;
        //     CreatedDate = createdDate;
        //     SKU = Guid.NewGuid();
        //     Attributes = null;
        // }

        public Product()
        {
            SKU = Guid.NewGuid();
        }


    }
}