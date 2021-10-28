using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductManagementAPI.Dtos;
using ProductManagementAPI.Repositories;

namespace ProductManagementAPI.Controllers
{
    [ApiController]
    [Route("productAttributes")]
    public class AttributeController : ControllerBase
    {
        private readonly IAttributeRepository _repo;

        public AttributeController(IAttributeRepository _repo)
        {
            this._repo = _repo;
        }

        //GET /productAttributes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AttributeDto>>> GetAttributes()
        {
            var attribute = await _repo.GetAttributes();
            return Ok(attribute);
        }

        [HttpGet("/productAttributeValues/{id}")]
        public async Task<ActionResult<AttributeDto>> GetAttribute(Guid id)
        {
            var attribute = await _repo.GetAttribute(id);

            if (attribute is null)
            {
                return NotFound();
            }

            return Ok(attribute.AsAttributeDto());
        }
    }
}