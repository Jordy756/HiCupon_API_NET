using HiCupon.API.DTOs;
using HiCupon.API.Utility;
using HiCupon.BW.Interfaces.BW;
using Microsoft.AspNetCore.Mvc;

namespace HiCupon.API.Controllers
{
    [Route("Bill")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IManageBillBW _manageBillBW;

        public BillController(IManageBillBW manageBillBW)
        {
            _manageBillBW = manageBillBW;
        }

        [HttpPost("InsertBill/{userId}")]
        public async Task<IActionResult> InsertBill(BillDTO billDTO, int userId)
        {
            try
            {
                return Ok(new { message = await _manageBillBW.InsertBill(BillMapper.MapToBill(billDTO), userId) });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("GetBillsByUser/{userId}")]
        public async Task<IActionResult> GetBillsByUser(int userId)
        {
            try
            {
                return Ok(BillMapper.MapToBillDTOs(await _manageBillBW.GetBillsByUser(userId)));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
