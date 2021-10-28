using System.ComponentModel.DataAnnotations;

namespace ProductManagementAPI.Dtos
{
    public class UpdateProductDto
    {

        public string Name { get; init; }
        public string Brand { get; init; }
        public decimal Price { get; init; }
        [Range(1, 1000)]
        public int Quantity { get; init; }
    }
}
