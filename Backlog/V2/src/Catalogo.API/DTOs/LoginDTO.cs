using System.ComponentModel.DataAnnotations;
using Catalogo.API.Validators;

namespace Catalogo.API.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Username is required")]
        [MinLength(3, ErrorMessage = "Username must be at least 3 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(3, ErrorMessage = "Password must be at least 3 characters")]
        
        [ValidPassword]
        public string Password { get; set; }
    }
}
