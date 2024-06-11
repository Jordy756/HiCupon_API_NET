using HiCupon.BC.Models;

namespace HiCupon.BW.Interfaces.DA
{
    public interface IManageBillDA
    {
        Task<string> InsertBill(Bill bill, int userId);
        Task<IEnumerable<Bill>> GetBillsByUser(int userId);
    }
}
