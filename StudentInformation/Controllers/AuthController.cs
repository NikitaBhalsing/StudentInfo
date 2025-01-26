using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using StudentInformation.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace StudentInformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request.Username == "nikita" && request.Password == "test@123")
            {
                var token = GenerateJwtToken();
                return Ok(new { Token = token });
            }

            return Unauthorized("Invalid credentials.");
        }

        private string GenerateJwtToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("NikitaGanpatBhalsing"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "nikita",
                audience: "mycompany",
                expires: DateTime.Now.AddHours(1),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
