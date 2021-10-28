using System;
using System.Collections.Generic;

namespace ProductManagementAPI.Dtos
{
    public record AttributeDto
    {
        public Guid Id { get; set; }
        public Guid ProductSKU { get; set; }
        public string Name { get; set; }
        public List<string> AttributeValues { get; set; }
    }
}