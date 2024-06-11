using HiCupon.BC.Models;
using HiCupon.BW.Interfaces.BW;
using HiCupon.BW.Interfaces.DA;

namespace HiCupon.BW.CU
{
    public class ManageBillBW : IManageBillBW
    {
        private readonly IManageBillDA _manageBillDA;

        public ManageBillBW(IManageBillDA manageBillDA)
        {
            _manageBillDA = manageBillDA;
        }

        public async Task<string> InsertBill(Bill bill, int userId)
        {
            return await _manageBillDA.InsertBill(bill, userId);
        }
        
        public async Task<IEnumerable<Bill>> GetBillsByUser(int userId)
        {
            return await _manageBillDA.GetBillsByUser(userId);
        }

        
    }
}
