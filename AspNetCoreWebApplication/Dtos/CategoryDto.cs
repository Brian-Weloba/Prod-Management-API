using System;

namespace ProductManagementAPI.Dtos
{
    public record CategoryDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
    }
}