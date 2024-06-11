using HiCupon.API.DTOs;
using HiCupon.API.Utility;
using HiCupon.BW.Interfaces.BW;
using Microsoft.AspNetCore.Mvc;

namespace HiCupon.API.Controllers
{
    [Route("User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IManageUserBW _manageUserBW;

        public UserController(IManageUserBW manageUserBW)
        {
            _manageUserBW = manageUserBW;
        }

        [HttpPost("InsertUser")]
        public async Task<IActionResult> InsertUser(UserDTO userDTO)
        {
            try
            {
                return Ok(new { message = await _manageUserBW.InsertUser(UserMapper.MapToUser(userDTO)) });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("AuthenticateUser/{email}/{password}")]
        public async Task<IActionResult> AuthenticateCustomer(string email, string password)
        {
            try
            {
                return Ok(UserMapper.MapToUserDTO(await _manageUserBW.AuthenticateUser(email, password)));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
