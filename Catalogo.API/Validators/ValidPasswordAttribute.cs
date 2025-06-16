using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Catalogo.API.Validators
{
    public class ValidPasswordAttribute : ValidationAttribute
    {
        private static readonly string[] WeakPasswords = { "123", "password", "12345" };

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var password = value?.ToString();

            if (WeakPasswords.Contains(password))
            {
                return new ValidationResult("This password is too weak. Choose a stronger password.");
            }

            return ValidationResult.Success;
        }
    }
}
