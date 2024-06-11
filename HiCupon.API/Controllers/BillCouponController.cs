using HiCupon.API.DTOs;
using HiCupon.API.Utility;
using HiCupon.BW.CU;
using HiCupon.BW.Interfaces.BW;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HiCupon.API.Controllers
{
    [Route("BillCoupon")]
    [ApiController]
    public class BillCouponController : ControllerBase
    {
        private readonly IManageBillCouponBW _manageBillCouponBW;

        public BillCouponController(IManageBillCouponBW manageBillCouponBW)
        {
            _manageBillCouponBW = manageBillCouponBW;
        }

        [HttpPost("InsertBillCoupon/{billId}")]
        public async Task<IActionResult> InsertBillCoupon(BillCouponDTO billCouponDTO, int billId)
        {
            try
            {
                return Ok(new { message = await _manageBillCouponBW.InsertBillCoupon(BillCouponMapper.MapToBillCoupon(billCouponDTO), billId) });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("GetBillCouponsByBill/{billId}")]
        public async Task<IActionResult> GetBillCouponsByBill(int billId)
        {
            try
            {
                return Ok(BillCouponMapper.MapToBillCouponDTOs(await _manageBillCouponBW.GetBillCouponsByBill(billId)));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
