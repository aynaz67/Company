using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using Company.Application.DTOs;
using Company.Infrastructure.Repositories;
using Company.Application.Interface;

namespace CompanyWeb.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
     
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequestDto loginRequest)
        {
            var user = await _userService.AuthenticateAsync(
                loginRequest.UserName, loginRequest.Password);

            if (user != null)
            {
                //Generate JWT
           //     var token = await tokenHandler.CreateTokenAsync(user);
                // return Ok(token);
                return View("Index");
            }

            return BadRequest("username and password is incorect");
        }

    }
}
