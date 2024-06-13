using HiCupon.BC.Models;
using HiCupon.BW.Interfaces.BW;
using HiCupon.BW.Interfaces.SG;

namespace HiCupon.BW.CU
{
    public class ManageCouponBW : IManageCouponBW
    {
        private readonly IManageCouponSG _manageCouponSG;

        public ManageCouponBW(IManageCouponSG manageCouponSG)
        {
            _manageCouponSG = manageCouponSG;
        }

        public async Task<IEnumerable<Coupon>> GetSomeCoupons(string search, string category, int page, int elements)
        {
            return await _manageCouponSG.GetSomeCoupons(search, category, page, elements);
        }

        public async Task<IEnumerable<Coupon>> GetSomeCouponsOfCustomer(string coupons, int page, int elements)
        {
            return await _manageCouponSG.GetSomeCouponsOfCustomer(coupons, page, elements);
        }
    }
}
