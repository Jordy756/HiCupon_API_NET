using HiCupon.BC.Models;

namespace HiCupon.BW.Interfaces.BW
{
    public interface IManageCouponBW
    {
        Task<IEnumerable<Coupon>> GetSomeCoupons(string search, string category, int page, int elements);
    }
}
