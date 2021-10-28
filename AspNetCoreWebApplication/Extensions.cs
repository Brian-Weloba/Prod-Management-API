using ProductManagementAPI.Dtos;
using ProductManagementAPI.Entities;

namespace ProductManagementAPI
{
    public static class Extensions
    {
        public static ProductDto AsProductDto(this Product product)
        {
            return new ProductDto
            {
                Name = product.Name,
                Brand = product.Brand,
                Price = product.Price,
                Quantity = product.Quantity,
                CreatedDate = product.CreatedDate,
                Attributes = product.Attributes,
                SKU = product.SKU
            };
        }

        public static CategoryDto AsCategoryDto(this ProductCategory productCategory)
        {
            return new CategoryDto
            {
                Id = productCategory.Id,
                Name = productCategory.Name,
                Description = productCategory.Description
            };
        }

        public static AttributeDto AsAttributeDto(this ProductAttributes productAttributes)
        {
            return new AttributeDto
            {
                Id = productAttributes.Id,
                Name = productAttributes.Name,
                ProductSKU =productAttributes.ProductSKU,
                AttributeValues = productAttributes.AttributeValues
            };
        }
    }
}