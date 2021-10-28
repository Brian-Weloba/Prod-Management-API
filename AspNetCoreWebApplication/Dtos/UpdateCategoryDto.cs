using System.ComponentModel.DataAnnotations;

namespace ProductManagementAPI.Dtos
{
    public record UpdateCategoryDto
    {
        public string Name { get; init; }
        public string Description { get; init; }
    }
}