using HiCupon.BC.Models;
using HiCupon.DA.Entities;

namespace HiCupon.DA.Utility
{
    public class BillCouponMapper
    {
        public static BillCouponDA MapToBillCouponDA(BillCoupon billCoupon, int billId)
        {
            BillCouponDA billCouponDA = new()
            {
                BillDA = new BillDA()
                {
                    Id = billId
                },
                CouponId = billCoupon.Coupon.Id,
                Quantity = billCoupon.Quantity
            };

            return billCouponDA;
        }
    }
}
