using HiCupon.BC.Models;

namespace HiCupon.BC.BusinessRules
{
    public class BillCouponRules
    {
        public static bool ValidateBillCoupon(BillCoupon billCoupon)
        {
            //if (billCoupon.Bill.Id <= 0) throw new Exception("El id de la factura no puede ser menor o igual a 0");
            //if (billCoupon.Coupon <= 0) throw new Exception("El id del cupón no puede ser menor o igual a 0");
            //if (billCoupon.Quantity <= 0) throw new Exception("La cantidad no puede ser menor o igual a 0");
            
            return true;
        }
    }
}
