using System;
using System.ComponentModel.DataAnnotations;

namespace ProductManagementAPI.Dtos
{
    public record CreateProductDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        public string Brand { get; init; }
        [Required]
        public decimal Price { get; init; }
        [Required]
        [Range(1,1000)]
        public int Quantity { get; init; }
        // public Guid SKU { get; init; }
        // public CreateProductDto()
        // {
        //     SKU = Guid.NewGuid();
        // }
    }
}