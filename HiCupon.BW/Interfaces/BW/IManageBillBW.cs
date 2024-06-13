using HiCupon.BC.Models;

namespace HiCupon.BW.Interfaces.BW
{
    public interface IManageBillBW
    {
        Task<(bool, string)> InsertBill(Bill bill, int userId);
        Task<IEnumerable<Bill>> GetBillsByUser(int userId);
    }
}
