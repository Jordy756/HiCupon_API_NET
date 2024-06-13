using HiCupon.BC.Models;
using HiCupon.BW.Interfaces.DA;
using HiCupon.DA.Context;
using HiCupon.DA.Entities;
using Microsoft.EntityFrameworkCore;

namespace HiCupon.DA.Actions
{
    public class ManageBillDA : IManageBillDA
    {
        private readonly HiCouponContext _context;

        public ManageBillDA(HiCouponContext context)
        {
            _context = context;
        }

        public async Task<(bool, string)> InsertBill(Bill bill, int userId)
        {
            UserDA userDA = await _context.UserDAs.FindAsync(userId) ?? new();

            if (userDA.Id == 0) return (false, "El usuario no existe");

            BillDA billDA = new ()
            {
                UserDA = userDA,
                TotalBasePrice = bill.TotalBasePrice,
                TotalDiscount = bill.TotalDiscount,
                TotalTax = bill.TotalTax,
                TotalPrice = bill.TotalPrice,
                BillCouponDAs = bill.BillCoupons.Select(billCouponDA => new BillCouponDA
                {
                    CouponId = billCouponDA.Coupon.Id,
                    Quantity = billCouponDA.Quantity,
                    TotalBasePrice = billCouponDA.TotalBasePrice,
                    TotalDiscount = billCouponDA.TotalDiscount,
                    TotalTax = billCouponDA.TotalTax,
                    TotalPrice = billCouponDA.TotalPrice
                }).ToList()
            };

            await _context.BillDAs.AddAsync(billDA);
            var result = await _context.SaveChangesAsync();

            return result > 0 ? (true, "Compra realizada con exito") : (false, "Error al realizar la compra");
        }

        public async Task<IEnumerable<Bill>> GetBillsByUser(int userId)
        {
            return await _context.BillDAs
                .Where(billDA => billDA.UserDA.Id == userId)
                .Select(billDA => new Bill (
                    billDA.Id,
                    billDA.TotalBasePrice,
                    billDA.TotalDiscount,
                    billDA.TotalTax,
                    billDA.TotalPrice,
                    billDA.BillCouponDAs.Select(billCouponDA => new BillCoupon (
                        billCouponDA.Id,
                        new Coupon(billCouponDA.CouponId),
                        billCouponDA.Quantity,
                        billCouponDA.TotalBasePrice,
                        billCouponDA.TotalDiscount,
                        billCouponDA.TotalTax,
                        billCouponDA.TotalPrice
                    ))
                )).ToListAsync();
        }
    }
}
