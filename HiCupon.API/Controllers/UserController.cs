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
                var result = await _manageUserBW.InsertUser(UserMapper.MapToUser(userDTO));
                return result.Item1 ? Ok(new { message = result.Item2 }) : BadRequest(new { message = result.Item2 });
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
                var user = await _manageUserBW.AuthenticateUser(email, password);
                return user.Id > 0 ? Ok(UserMapper.MapToUserDTO(user)) : BadRequest("Usuario no encontrado");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
