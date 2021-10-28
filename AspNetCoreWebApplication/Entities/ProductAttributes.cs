using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductManagementAPI.Entities
{
    public record ProductAttributes
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProductSKU { get; set; }
        public string Name { get; set; }
        public List<string> AttributeValues { get; set; }
        public ProductAttributes()
        {
            Id = Guid.NewGuid();
        }
    }
}