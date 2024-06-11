using HiCupon.BC.Models;
using HiCupon.DA.Entities;

namespace HiCupon.DA.Utility
{
    public class BillMapper
    {
        public static BillDA MapToBillDA(Bill bill, int userId)
        {
            BillDA billDA = new()
            {
                UserDA = new UserDA()
                {
                    Id = userId
                },
                BasePrice = bill.BasePrice,
                Iva = bill.Iva,
                Total = bill.Total
            };

            return billDA;
        }
    }
}
