using System.ComponentModel.DataAnnotations;
using Catalogo.API.Entities;

namespace Catalogo.API.Validators
{
    public class ValidProductUpdateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var product = value as Product;
            if (product == null)
                return new ValidationResult("Invalid product object.");

            if (string.IsNullOrWhiteSpace(product.Name))
                return new ValidationResult("Product name cannot be empty.");

            return ValidationResult.Success;
        }
    }
}
