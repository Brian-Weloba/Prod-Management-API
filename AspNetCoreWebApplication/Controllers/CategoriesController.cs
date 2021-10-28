using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductManagementAPI.Dtos;
using ProductManagementAPI.Entities;
using ProductManagementAPI.Repositories;

namespace ProductManagementAPI.Controllers
{
    [ApiController]
    [Route("productCategories")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _repo;

        public CategoriesController(ICategoryRepository _repo)
        {
            this._repo = _repo;
        }
        //GET /productCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetCategories()
        {
            var categories = await _repo.getProductCategories();
            return Ok(categories);
        }

        //GET /productCategories/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> getCategory(Guid id)
        {
            var category = await _repo.GetProductCategory(id);

            if (category is null)
            {
                return NotFound();
            }

            return Ok(category.AsCategoryDto());
        }

        [HttpPost("/productCategory")]
        public async Task<ActionResult<CategoryDto>> CreateCategory(CreateCategoryDto categoryDto)
        {
            ProductCategory productCategory = new()
            {
                Name = categoryDto.Name,
                Description = categoryDto.Description
            };

            await _repo.CreateProductCategory(productCategory);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCategory(Guid id, UpdateCategoryDto categoryDto)
        {
            ProductCategory updatedCategory = new(){
                Name = categoryDto.Name,
                Description = categoryDto.Description
            };

            await _repo.UpdateProductCategory(updatedCategory);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCategory(Guid id)
        {
            var existingCategory =_repo.GetProductCategory(id);

            if (existingCategory is null)
            {
                return NoContent();
            }

            await _repo.DeleteProductCategory(id);

            return Ok();

        }

    }

}