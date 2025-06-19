using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;

namespace Catalogo.API.Validators
{
    public class ValidObjectIdAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || !ObjectId.TryParse(value.ToString(), out _))
            {
                return new ValidationResult("Invalid ObjectId format.");
            }

            return ValidationResult.Success;
        }
    }
}
