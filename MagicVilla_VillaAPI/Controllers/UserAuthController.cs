using System.Net;
using Asp.Versioning;
using MagicVilla.Models.Models.APIResponse;
using MagicVilla.Models.Models.DTOs.AuthDTOs;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersionNeutral]
    public class UserAuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserAuthController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        protected APIResponse _response = new();

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO dto)
        {
            var response = await _userRepository.Login(dto);
            if (response.User == null || string.IsNullOrEmpty(response.Token))
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.ErrorMessages!.Add("Invalid username or password");
                return BadRequest(_response);
            }

            _response.StatusCode = HttpStatusCode.OK;
            _response.IsSuccess = true;
            _response.Result = response;
            return Ok(_response);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterationRequestDTO dto)
        {
            bool isUnique = _userRepository.IsUniqueUser(dto.UserName);
            if (!isUnique)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.ErrorMessages!.Add("User already exists");
                return BadRequest(_response);
            }

            var user = await _userRepository.Register(dto);
            if (user == null)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.ErrorMessages!.Add("Registration failed");
                return BadRequest(_response);
            }

            _response.StatusCode = HttpStatusCode.OK;
            _response.IsSuccess = true;
            _response.Result = user;
            return Ok(_response);
        }
    }
}
