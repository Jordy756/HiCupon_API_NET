using HiCupon.BC.Models;

namespace HiCupon.BW.Interfaces.DA
{
    public interface IManageBillCouponDA
    {
        Task<string> InsertBillCoupon(BillCoupon billCoupon, int billId);
        Task<IEnumerable<BillCoupon>> GetBillCouponsByBill(int billId);
    }
}
