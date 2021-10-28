using System;
using System.ComponentModel.DataAnnotations;

namespace ProductManagementAPI.Dtos
{
    public record CreateCategoryDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        public string Description { get; init; }
    }
}