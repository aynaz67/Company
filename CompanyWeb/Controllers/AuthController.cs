using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using Company.Application.DTOs;
using Company.Application.Services.Interfaces;
using Company.Infrastructure.Repositories;

namespace CompanyWeb.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenHandler tokenHandler;

        public AuthController(IUserRepository userRepository, ITokenHandler tokenHandler)
        {
            _userRepository = userRepository;
            this.tokenHandler = tokenHandler;
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginRequestDto loginRequest)
        {
            var user = await _userRepository.AuthenticateAsync(
                loginRequest.UserName, loginRequest.Password);

            if (user != null)
            {
                //Generate JWT
                var token= await tokenHandler.CreateTokenAsync(user);
                return Ok(token);
            }

            return BadRequest("username and password is incorect");
        }

    }
}
