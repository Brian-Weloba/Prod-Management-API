using System;
using System.ComponentModel.DataAnnotations;

namespace ProductManagementAPI.Entities
{
    public record ProductCategory
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description{get;set;}
        public ProductCategory(){
            Id = Guid.NewGuid();
        }
    }
}