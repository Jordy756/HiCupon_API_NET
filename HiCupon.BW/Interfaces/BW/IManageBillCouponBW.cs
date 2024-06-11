using HiCupon.BC.Models;

namespace HiCupon.BW.Interfaces.BW
{
    public interface IManageBillCouponBW
    {
        Task<string> InsertBillCoupon(BillCoupon billCoupon, int billId);
        Task<IEnumerable<BillCoupon>> GetBillCouponsByBill(int billId);
    }
}
