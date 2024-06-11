using HiCupon.BC.Models;
using HiCupon.BW.Interfaces.DA;
using HiCupon.DA.Context;
using HiCupon.DA.Entities;
using Microsoft.EntityFrameworkCore;

namespace HiCupon.DA.Actions
{
    public class ManageBillCouponDA : IManageBillCouponDA
    {
        private readonly HiCouponContext _context;

        public ManageBillCouponDA(HiCouponContext context)
        {
            _context = context;
        }

        public async Task<string> InsertBillCoupon(BillCoupon billCoupon, int billId)
        {
            BillDA billDA = await _context.BillDAs.FindAsync(billId) ?? new();

            if (billDA.Id == 0) throw new Exception("La factura no existe");

            BillCouponDA billCouponDA = new()
            {
                BillDA = billDA,
                CouponId = billCoupon.CouponId,
                Quantity = billCoupon.Quantity
            };

            await _context.BillCouponDAs.AddAsync(billCouponDA);
            var result = await _context.SaveChangesAsync();

            if (result == 0) throw new Exception("No se ha podido realizar la compra");

            return "La compra se realizó de manera exitosa";
        }
        
        public async Task<IEnumerable<BillCoupon>> GetBillCouponsByBill(int billId)
        {
            return await _context.BillCouponDAs
                .Where(billCouponDA => billCouponDA.BillDA.Id == billId)
                .Select(billCouponDA => new BillCoupon(
                    billCouponDA.Id,
                    new Bill(
                        billCouponDA.BillDA.Id,
                        new User(),
                        billCouponDA.BillDA.BasePrice,
                        billCouponDA.BillDA.Iva,
                        billCouponDA.BillDA.Total,
                        new List<BillCoupon>()
                        ),
                    billCouponDA.CouponId,
                    billCouponDA.Quantity
                    )).ToListAsync();
        } 
    }
}
