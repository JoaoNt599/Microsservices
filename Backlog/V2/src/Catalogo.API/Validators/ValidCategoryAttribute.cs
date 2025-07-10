using System.ComponentModel.DataAnnotations;

namespace Catalogo.API.Validators
{
    public class ValidCategoryAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return new ValidationResult("Category is required");
            }

            if (value.ToString().Length < 3)
            {
                return new ValidationResult("Category must be at least 3 characters");
            }

            return ValidationResult.Success;
        }
    }
}
