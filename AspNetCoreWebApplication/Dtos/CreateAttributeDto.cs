using System;
using System.Collections.Generic;

namespace ProductManagementAPI.Dtos
{
    public record CreateAttributeDto
    {
        public string Name { get; set; }
        public List<string> AttributeValues { get; set; }
    }
}