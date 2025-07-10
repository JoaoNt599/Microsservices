using Basket.API.DTOs;
using Basket.API.Entities;
using Basket.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Basket.API.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly TokenService _tokenService;

        private readonly List<User> _users = new List<User>
        {
            new User { Username = "admin", Password = "123456" },
            new User { Username = "user", Password = "123" }
        };

        public LoginController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO dto)
        {
            var user = _users.Find(u => u.Username == dto.Username && u.Password == dto.Password);

            if (user == null)
                return Unauthorized("Credenciais inválidas");

            var token = _tokenService.GenerateToken(user);

            return Ok(new { token });
        }
    }
}
