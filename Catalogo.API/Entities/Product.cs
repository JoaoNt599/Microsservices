using System;
using System.ComponentModel.DataAnnotations;
using Catalogo.API.Validators;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalogo.API.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        [Required(ErrorMessage = "Product name is required")]
        [MinLength(3, ErrorMessage = "Product name must be at least 3 characters")]
        public string Name { get; set; }

        [ValidCategory]
        public string Category { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
        
        public string Image { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
        public decimal Price { get; set; }
    }
}