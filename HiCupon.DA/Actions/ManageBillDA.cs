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
        public async Task<string> InsertBill(Bill bill, int userId)
        {
            UserDA userDA = await _context.UserDAs.FindAsync(userId) ?? new();

            if (userDA.Id == 0) throw new Exception("El usuario no existe");

            BillDA billDA = new()
            {
                UserDA = userDA,
                BasePrice = bill.BasePrice,
                Iva = bill.Iva,
                Total = bill.Total,
                BillCouponDAs = bill.BillCoupons.Select(r => new BillCouponDA
                {
                    BillDA = _context.BillDAs.Find(r.Coupon.Id) ?? new(),
                }).ToList()
            };

            await _context.BillDAs.AddAsync(billDA);
            var result = await _context.SaveChangesAsync();

            if (result == 0) throw new Exception("No se ha podido realizar la compra");

            return "La compra se realizó de manera exitosa";
        }

        public async Task<IEnumerable<Bill>> GetBillsByUser(int userId)
        {

            return await _context.BillDAs
                .Where(billDA => billDA.UserDA.Id == userId)
                .Select(billDA => new Bill(
                    billDA.Id,
                    billDA.BasePrice,
                    billDA.Iva,
                    billDA.Total,
                    billDA.BillCouponDAs.Select(billCouponDA => new BillCoupon (
                        billCouponDA.Id,
                        new Coupon(),
                        billCouponDA.Quantity
                    ))
                )).ToListAsync();
        }
    }
}
