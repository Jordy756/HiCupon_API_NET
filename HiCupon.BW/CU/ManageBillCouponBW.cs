using HiCupon.BC.Models;
using HiCupon.BW.Interfaces.BW;
using HiCupon.BW.Interfaces.DA;

namespace HiCupon.BW.CU
{
    public class ManageBillCouponBW : IManageBillCouponBW
    {
        private readonly IManageBillCouponDA _manageBillCouponDA;

        public ManageBillCouponBW(IManageBillCouponDA manageBillCouponDA)
        {
            _manageBillCouponDA = manageBillCouponDA;
        }

        public async Task<string> InsertBillCoupon(BillCoupon billCoupon, int billId)
        {
            return await _manageBillCouponDA.InsertBillCoupon(billCoupon, billId);
        }
        
        public async Task<IEnumerable<BillCoupon>> GetBillCouponsByBill(int billId)
        {
            return await _manageBillCouponDA.GetBillCouponsByBill(billId);
        } 
    }
}
