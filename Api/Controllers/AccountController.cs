using Api.Data;
using Api.DTOs;
using Api.Entities;
using Api.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly UserManager<User> _userManager;
        private readonly ApplicationContext _context;
        private readonly TokenService _tokenService;
        public AccountController(UserManager<User> userManager, ApplicationContext context , TokenService tokenService)
        {
            _userManager = userManager;
            _context = context;
            _tokenService = tokenService;
        }
        [HttpPost("register")]
        public async Task<ActionResult<RegisterDto>> Register(RegisterDto registerDto)
        //check if user exist
        {
            var user = await _userManager.FindByEmailAsync(registerDto.EmailAddress);
            if (user != null) return BadRequest("Email is taken");
            var newUser = new User
            {
                UserName = registerDto.UserName,
                Email = registerDto.EmailAddress,
            };

            var result = await _userManager.CreateAsync(newUser, registerDto.Password);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            await _userManager.AddToRoleAsync(newUser, "Member");
            await _context.SaveChangesAsync();
            return Ok();
        }

        //login endpoint
        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LogInDto logInDto)
        {
            var user = await _userManager.Users
                 .SingleOrDefaultAsync(x => x.Email == logInDto.EmailAddress);
            if (user == null) return Unauthorized("Invalid Email");
            var result = await _userManager.CheckPasswordAsync(user, logInDto.Password);
            if (!result) return Unauthorized();
            return new UserDto
            {
                UserName = user.UserName,
                EmailAddress = user.Email,
                Token = await _tokenService.CreateToken(user)
            };
            
        }
    }
}