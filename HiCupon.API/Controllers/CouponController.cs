using HiCupon.API.Utility;
using HiCupon.BW.Interfaces.BW;
using Microsoft.AspNetCore.Mvc;

namespace HiCupon.API.Controllers
{
    [Route("Coupon")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private readonly IManageCouponBW _manageCouponBW;

        public CouponController(IManageCouponBW manageCouponBW)
        {
            _manageCouponBW = manageCouponBW;
        }

        [HttpGet("GetSomeCoupons/{page}/{elements}")]
        public async Task<IActionResult> GetSomeCoupons(int page, int elements, string? search = null, string? category = null)
        {
            try
            {
                var coupons = CouponMapper.MapToCouponDTOs(await _manageCouponBW.GetSomeCoupons(search ?? "", category ?? "", page, elements));
                return Ok(coupons);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
