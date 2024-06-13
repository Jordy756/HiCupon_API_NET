using HiCupon.BC.Models;
using HiCupon.BW.Interfaces.BW;
using HiCupon.BW.Interfaces.DA;
using HiCupon.BW.Interfaces.SG;
using Newtonsoft.Json;

namespace HiCupon.BW.CU
{
    public class ManageBillBW : IManageBillBW
    {
        private readonly IManageBillDA _manageBillDA;
        private readonly IManageCouponSG _manageCouponSG;

        public ManageBillBW(IManageBillDA manageBillDA, IManageCouponSG manageCouponSG)
        {
            _manageBillDA = manageBillDA;
            _manageCouponSG = manageCouponSG;
        }

        public async Task<(bool, string)> InsertBill(Bill bill, int userId)
        {
            return await _manageBillDA.InsertBill(bill, userId);
        }
        
        public async Task<IEnumerable<Bill>> GetBillsByUser(int userId)
        {
            var bills = await _manageBillDA.GetBillsByUser(userId);
            
            foreach (Bill bill in bills)
            {
                IEnumerable<Coupon> coupons = await _manageCouponSG.GetSomeCouponsOfCustomer(GetBillCouponIdsJson(bill.BillCoupons), 1, 100);
                bill.BillCoupons = bill.BillCoupons.Select(bc => { bc.Coupon = coupons.FirstOrDefault(c => c.Id == bc.Coupon.Id); return bc; });
            }
            return bills;
        }

        public static string GetBillCouponIdsJson(IEnumerable<BillCoupon> billCoupons)
        {
            return JsonConvert.SerializeObject(billCoupons.Select(r => new
            {
                id = r.Coupon.Id,
            }));
        }
    }
}
