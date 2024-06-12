using HiCupon.BC.Models;

namespace HiCupon.BW.Interfaces.SG
{
    public interface IManageCategorySG
    {
        Task<IEnumerable<Category>> GetAllCategories();
    }
}
